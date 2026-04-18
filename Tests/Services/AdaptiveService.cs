using AdaptiveAlgebraTest.Enums;
using AdaptiveAlgebraTest.Models;

namespace AdaptiveAlgebraTest.Services
{
    class AdaptiveService
    {
        public int CalculateInitialDifficulty(UserProfile user)
        {
            int diff = 2;

            if (user.Depth == DepthLevel.Surface)
                diff = 1;
            else if (user.Depth == DepthLevel.Deep)
                diff = 3;

            if (user.Grade <= 8)
                diff = Math.Max(1, diff - 1);
            else if (user.Grade >= 10)
                diff = Math.Min(3, diff + 1);

            if (user.TimeBudget == TimeBudget.Low)
                diff = Math.Max(1, diff - 1);

            return diff;
        }

        public AdaptiveSettings GetAdaptiveSettings(UserProfile user, string topic)
        {
            var settings = new AdaptiveSettings();

            var topicHistory = user.History.Where(h => h.TopicName == topic).ToList();
            var last = topicHistory.LastOrDefault();

            if (last.TotalScore == 0 && topicHistory.Count > 0)
            {
                settings.SimplifyEverything = true;
                settings.ForceTheory = true;
            }
            else if (last.TotalScore < last.MaxScore * 0.5)
            {
                settings.EmphasizeTopic = true;
                settings.HardStepByStep = true;
            }
            else if (last.TotalScore >= last.MaxScore * 0.9)
            {
                settings.Reinforcement = true;
            }

            settings.EasyDifficulty = Difficulty.Easy;
            settings.MediumDifficulty = Difficulty.Medium;
            settings.HardDifficulty = Difficulty.Hard;

            return settings;
        }

        public void UpdateTopicMastery(UserProfile user, string topic, TestResult result)
        {
            double percent = (double)result.TotalScore / result.MaxScore * 100;

            user.TopicMastery[topic] = (int)percent;
        }
    }
}
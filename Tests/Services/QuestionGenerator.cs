using AdaptiveAlgebraTest.Enums;
using AdaptiveAlgebraTest.Models;

namespace AdaptiveAlgebraTest.Services
{
    class QuestionGenerator
    {
        public Question GenerateEasy(string topic)
        {
            if (topic == "Алгебра")
                return new Question { Text = "2x = 10", CorrectAnswer = "5", Points = 1, Level = Difficulty.Easy, Topic = topic };

            return new Question { Text = "5 + 3", CorrectAnswer = "8", Points = 1, Level = Difficulty.Easy, Topic = topic };
        }

        public Question GenerateMedium(string topic)
        {
            if (topic == "Алгебра")
                return new Question { Text = "x² - 3x + 2 = 0", CorrectAnswer = "1,2", Points = 2, Level = Difficulty.Medium, Topic = topic };

            return new Question { Text = "Катеты 6 и 8", CorrectAnswer = "10", Points = 2, Level = Difficulty.Medium, Topic = topic };
        }

        public Question GenerateHard(string topic)
        {
            if (topic == "Алгебра")
                return new Question { Text = "Сумма: 2,5,8,11", CorrectAnswer = "26", Points = 3, Level = Difficulty.Hard, Topic = topic };

            return new Question { Text = "Площадь круга = 16π", CorrectAnswer = "4", Points = 3, Level = Difficulty.Hard, Topic = topic };
        }
    }
}
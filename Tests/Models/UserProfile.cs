using AdaptiveAlgebraTest.Enums;

namespace AdaptiveAlgebraTest.Models
{
    struct UserProfile
    {
        public int Grade;
        public DepthLevel Depth;
        public TimeBudget TimeBudget;
        public int OverallDifficulty;
        public List<TestResult> History;
        public Dictionary<string, int> TopicMastery;
        public Dictionary<string, int> TopicRepeatCount;
    }
}
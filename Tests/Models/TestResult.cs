using AdaptiveAlgebraTest.Enums;

namespace AdaptiveAlgebraTest.Models
{
    struct TestResult
    {
        public string TopicName;
        public int EasyScore;
        public int MediumScore;
        public int HardScore;
        public int TotalScore;
        public int MaxScore;
        public TopicStatus Status;
        public List<Difficulty> FailedLevels;
        public DateTime Date;
        public int TimeSpentSeconds;
    }
}
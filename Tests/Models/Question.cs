using AdaptiveAlgebraTest.Enums;

namespace AdaptiveAlgebraTest.Models
{
    struct Question
    {
        public string Text;
        public string CorrectAnswer;
        public int Points;
        public Difficulty Level;
        public string Topic;
        public string Hint;
        public bool IsCore;
    }
}
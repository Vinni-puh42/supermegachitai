using System.Text.RegularExpressions;

namespace AdaptiveAlgebraTest.Utils
{
    static class AnswerChecker
    {
        public static bool Check(string userAnswer, string correctAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer)) return false;

            string u = Regex.Replace(userAnswer.ToLower().Trim(), @"\s+", "");
            string c = Regex.Replace(correctAnswer.ToLower().Trim(), @"\s+", "");

            u = u.Replace("х", "x");

            return u == c;
        }
    }
}
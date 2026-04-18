using AdaptiveAlgebraTest.Models;
using AdaptiveAlgebraTest.Utils;

namespace AdaptiveAlgebraTest.Services
{
    class TestEngine
    {
        AdaptiveService adaptive = new AdaptiveService();
        QuestionGenerator generator = new QuestionGenerator();
        TheoryService theory = new TheoryService();

        UserProfile user = new UserProfile
        {
            History = new List<TestResult>(),
            TopicMastery = new Dictionary<string, int>()
        };

        public void Run()
        {
            Console.WriteLine("ТЕСТ");

            string topic = "Алгебра";

            Console.WriteLine(theory.GetTheory(topic));

            var easy = generator.GenerateEasy(topic);

            Console.WriteLine(easy.Text);
            var ans = Console.ReadLine();

            bool correct = AnswerChecker.Check(ans, easy.CorrectAnswer);

            Console.WriteLine(correct ? "Верно" : "Ошибка");
        }
    }
}
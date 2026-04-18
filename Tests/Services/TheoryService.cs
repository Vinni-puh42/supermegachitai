namespace AdaptiveAlgebraTest.Services
{
    class TheoryService
    {
        public string GetTheory(string topic)
        {
            return topic switch
            {
                "Алгебра" => "Уравнение: найти x",
                "Геометрия" => "Сумма углов = 180°",
                _ => "Базовая теория"
            };
        }

        public string GetShortTheory(string topic)
        {
            return "Кратко: основные формулы";
        }

        public string GetExample(string topic)
        {
            return "Пример решения задачи";
        }
    }
}
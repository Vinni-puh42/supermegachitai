namespace AdaptiveAlgebraTest.Utils
{
    static class InputHelper
    {
        public static int ReadInt()
        {
            return int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
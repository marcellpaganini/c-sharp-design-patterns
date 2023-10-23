namespace DesignPatterns
{
    internal static class Helper
    {
        internal static void WriteTitle(string title)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow; 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}

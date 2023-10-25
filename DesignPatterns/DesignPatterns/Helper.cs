namespace DesignPatterns
{
    internal static class Helper
    {
        internal static void WriteSubtitle(string title)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow; 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine();
        }

        internal static void WriteTitle(string title)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;

            AddDivider(title);

            Console.WriteLine();
            Console.WriteLine(title);

            AddDivider(title);

            Console.ResetColor();
            Console.WriteLine();
        }

        private static void AddDivider(string title)
        {
            for (int i = 0; i < title.Count(); i++)
            {
                Console.Write("-");
            }
        }
    }
}

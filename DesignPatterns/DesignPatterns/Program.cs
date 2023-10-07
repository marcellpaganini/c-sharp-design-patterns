using Strategy;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNumberContext context = new RandomNumberContext();
            context.SetStrategy(new RandomIntegerStrategy());

            Console.WriteLine("--Random integer number strategy--");
            context.DisplayRandomNumber();

            context.SetStrategy(new RandomFloatStrategy());

            Console.WriteLine("--Random float number strategy--");
            context.DisplayRandomNumber();
        }
    }
}
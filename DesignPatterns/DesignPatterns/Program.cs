using Strategy;
using FactoryMethod;
using AbstractFactory;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**STRATEGY**");

            RandomNumberContext context = new RandomNumberContext();
            context.SetStrategy(new RandomIntegerStrategy());

            Console.WriteLine("--Random integer number strategy--");
            context.DisplayRandomNumber();

            context.SetStrategy(new RandomFloatStrategy());

            Console.WriteLine("--Random float number strategy--");
            context.DisplayRandomNumber();

            Console.WriteLine("**FACTORY METHOD**");

            Console.WriteLine("--Dog Factory--");
            Creator dogCreator = new DogCreator();
            IAnimal dog = dogCreator.Factory();
            Console.WriteLine(dog.MakeSound());

            Console.WriteLine("--Cat Factory--");
            Creator catCreator = new CatCreator();
            IAnimal cat = catCreator.Factory();
            Console.WriteLine(cat.MakeSound());

            Console.WriteLine("**ABSTRACT FACTORY**");

            NissanFactory nissanFactory = new NissanFactory();
            IVan nissanVan = nissanFactory.CreateVan();
            ISedan nissanSedan = nissanFactory.CreateSedanCar();

            Console.WriteLine(nissanVan.Expand());
            Console.WriteLine(nissanSedan.Brake());

            ToyotaFactory toyotaFactory = new ToyotaFactory();
            IElectric toyotaElectric = toyotaFactory.CreateElectricCar();
            ISedan toyotaSedan = toyotaFactory.CreateSedanCar();

            Console.WriteLine(toyotaSedan.Brake());
            Console.WriteLine(toyotaElectric.Recharge());
        }
    }
}
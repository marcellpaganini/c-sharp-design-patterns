using Strategy;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using FactoryMethod.Creators;
using FactoryMethod.Models;
using Observer;
using Adapter;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.WriteTitle("**STRATEGY**");

            RandomNumberContext context = new RandomNumberContext();
            context.SetStrategy(new RandomIntegerStrategy());

            Console.WriteLine("--Random integer number strategy--");
            context.DisplayRandomNumber();

            context.SetStrategy(new RandomFloatStrategy());

            Console.WriteLine("--Random float number strategy--");
            context.DisplayRandomNumber();

            Helper.WriteTitle("**FACTORY METHOD**");

            Console.WriteLine("--Dog Factory--");
            Creator dogCreator = new DogCreator();
            IAnimal dog = dogCreator.Factory();
            Console.WriteLine(dog.MakeSound());

            Console.WriteLine("--Cat Factory--");
            Creator catCreator = new CatCreator();
            IAnimal cat = catCreator.Factory();
            Console.WriteLine(cat.MakeSound());

            Helper.WriteTitle("**ABSTRACT FACTORY**");

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

            Helper.WriteTitle("**ADAPTER**");

            IJsonBasedLibrary jsonBasedLibrary = new JsonBasedLibrary();
            jsonBasedLibrary.DisplayData("current_format");

            IJsonBasedLibrary adaptedJsonLibrary = new DataFormatAdapter();
            adaptedJsonLibrary.DisplayData("new_format");

            Helper.WriteTitle("**OBSERVER**");

            ERBObservable observable = new ERBObservable();

            AlarmClassObserver alarmClassObserver = new AlarmClassObserver();
            observable.Add(alarmClassObserver);

            AlarmLevelObserver alarmLevelObserver = new AlarmLevelObserver();
            observable.Add(alarmLevelObserver);

            observable.SimulateAlarmLevelChange();
        }
    }
}
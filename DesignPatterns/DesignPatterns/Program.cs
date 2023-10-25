using Strategy;
using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using FactoryMethod.Creators;
using FactoryMethod.Models;
using Observer;
using Adapter;
using Singleton;
using Iterator;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.WriteTitle("**CREATIONAL PATTERNS**");

            Helper.WriteSubtitle("**FACTORY METHOD**");

            Console.WriteLine("--Dog Factory--");
            Creator dogCreator = new DogCreator();
            IAnimal dog = dogCreator.Factory();
            Console.WriteLine(dog.MakeSound());

            Console.WriteLine("--Cat Factory--");
            Creator catCreator = new CatCreator();
            IAnimal cat = catCreator.Factory();
            Console.WriteLine(cat.MakeSound());

            Helper.WriteSubtitle("**ABSTRACT FACTORY**");

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

            Helper.WriteSubtitle("**SINGLETON**");

            SingletonPattern s1 = SingletonPattern.GetInstance();
            SingletonPattern s2 = SingletonPattern.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine($"{nameof(s1)} and {nameof(s2)} are the same. Singleton works!");
            }
            else
            {
                {
                    Console.WriteLine("Different instances");
                }
            }

            Helper.WriteTitle("**STRUCTURAL PATTERNS**");

            Helper.WriteSubtitle("**ADAPTER**");

            IJsonBasedLibrary jsonBasedLibrary = new JsonBasedLibrary();
            jsonBasedLibrary.DisplayData("current_format");

            IJsonBasedLibrary adaptedJsonLibrary = new DataFormatAdapter();
            adaptedJsonLibrary.DisplayData("new_format");

            Helper.WriteTitle("**BEHAVIORAL PATTERNS**");

            Helper.WriteSubtitle("**STRATEGY**");

            RandomNumberContext context = new RandomNumberContext();
            context.SetStrategy(new RandomIntegerStrategy());

            Console.WriteLine("--Random integer number strategy--");
            context.DisplayRandomNumber();

            context.SetStrategy(new RandomFloatStrategy());

            Console.WriteLine("--Random float number strategy--");
            context.DisplayRandomNumber();

            Helper.WriteSubtitle("**OBSERVER**");

            ERBObservable observable = new ERBObservable();

            AlarmClassObserver alarmClassObserver = new AlarmClassObserver();
            observable.Add(alarmClassObserver);

            AlarmLevelObserver alarmLevelObserver = new AlarmLevelObserver();
            observable.Add(alarmLevelObserver);

            observable.SimulateAlarmLevelChange();

            observable.Remove(alarmClassObserver);
            observable.Remove(alarmLevelObserver);

            Helper.WriteSubtitle("**ITERATOR**");

            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Reverse traversal:");
            
            collection.ReverseDirection();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
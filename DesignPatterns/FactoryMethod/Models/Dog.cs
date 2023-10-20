namespace FactoryMethod.Models
{
    public class Dog : IAnimal
    {
        public string MakeSound()
        {
            return "Woof";
        }
    }
}
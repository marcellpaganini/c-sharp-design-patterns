namespace FactoryMethod.Models
{
    public class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Meow";
        }
    }
}

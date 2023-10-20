using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class DogCreator : Creator
    {
        public override IAnimal Factory()
        {
            return new Dog();
        }
    }
}

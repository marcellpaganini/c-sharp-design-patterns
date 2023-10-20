using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class CatCreator : Creator
    {
        public override IAnimal Factory()
        {
            return new Cat();
        }
    }
}

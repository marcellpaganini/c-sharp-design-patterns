using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public abstract class Creator
    {
        public abstract IAnimal Factory();
    }
}

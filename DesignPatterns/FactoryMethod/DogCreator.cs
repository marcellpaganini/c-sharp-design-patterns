using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DogCreator : Creator
    {
        public override IAnimal Factory()
        {
            return new Dog();
        }
    }
}

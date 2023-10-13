using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CatCreator : Creator
    {
        public override IAnimal Factory()
        {
            return new Cat();
        }
    }
}

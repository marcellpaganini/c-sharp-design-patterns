using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NissanSedan : ISedan
    {
        public string Accelerate()
        {
            return "Vrooom => Nissan";
        }

        public string Brake()
        {
            return "Screech => Nissan";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NissanElectric : IElectric
    {
        public string Accelerate()
        {
            return "Vrooom => Nissan";
        }

        public string Brake()
        {
            return "Screech => Nissan";
        }

        public string Recharge()
        {
            return "🔋🔋🔋 => Nissan";
        }
    }
}

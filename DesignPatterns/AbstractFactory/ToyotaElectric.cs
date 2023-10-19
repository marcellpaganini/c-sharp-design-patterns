using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ToyotaElectric : IElectric
    {
        public string Accelerate()
        {
            return "Vrooom => Toyota";
        }

        public string Brake()
        {
            return "Screech => Toyota";
        }

        public string Recharge()
        {
            return "🔋🔋🔋 => Toyota";
        }
    }
}

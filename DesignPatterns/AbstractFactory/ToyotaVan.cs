using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ToyotaVan : IVan
    {
        public string Accelerate()
        {
            return "Vrooom => Toyota";
        }

        public string Brake()
        {
            return "Screech => Toyota";
        }

        public string Expand()
        {
            return "🚐Expanding🚐 => Toyota";
        }
    }
}

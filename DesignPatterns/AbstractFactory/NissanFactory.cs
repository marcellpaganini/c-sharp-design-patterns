using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NissanFactory : ICarFactory
    {
        public IElectric CreateElectricCar()
        {
            return new NissanElectric();
        }

        public ISedan CreateSedanCar()
        {
            return new NissanSedan();
        }

        public IVan CreateVan()
        {
            return new NissanVan();
        }
    }
}

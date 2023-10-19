using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ToyotaFactory : ICarFactory
    {
        public IElectric CreateElectricCar()
        {
            return new ToyotaElectric();
        }

        public ISedan CreateSedanCar()
        {
            return new ToyotaSedan();
        }

        public IVan CreateVan()
        {
            return new ToyotaVan();
        }
    }
}

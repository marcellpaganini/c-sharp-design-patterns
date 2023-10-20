using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
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

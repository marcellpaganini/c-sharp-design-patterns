using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
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

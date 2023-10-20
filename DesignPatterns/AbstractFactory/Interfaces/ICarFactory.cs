namespace AbstractFactory.Interfaces
{
    public interface ICarFactory
    {
        public IElectric CreateElectricCar();
        public ISedan CreateSedanCar();
        public IVan CreateVan();
    }
}

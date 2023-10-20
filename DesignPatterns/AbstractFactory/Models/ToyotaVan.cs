using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
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
            return "Expanding... => Toyota";
        }
    }
}

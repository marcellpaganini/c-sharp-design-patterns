using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class NissanVan : IVan
    {
        public string Accelerate()
        {
            return "Vrooom => Nissan";
        }

        public string Brake()
        {
            return "Screech => Nissan";
        }

        public string Expand()
        {
            return "Expanding => Nissan";
        }
    }
}

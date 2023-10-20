using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class NissanSedan : ISedan
    {
        public string Accelerate()
        {
            return "Vrooom => Nissan";
        }

        public string Brake()
        {
            return "Screech => Nissan";
        }
    }
}

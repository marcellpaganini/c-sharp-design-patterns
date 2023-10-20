using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class ToyotaSedan : ISedan
    {
        public string Accelerate()
        {
            return "Vrooom => Toyota";
        }

        public string Brake()
        {
            return "Screech => Toyota";
        }
    }
}

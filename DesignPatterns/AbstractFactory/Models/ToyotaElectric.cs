using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class ToyotaElectric : IElectric
    {
        public string Accelerate()
        {
            return "Vrooom => Toyota";
        }

        public string Brake()
        {
            return "Screech => Toyota";
        }

        public string Recharge()
        {
            return "Recharging... => Toyota";
        }
    }
}

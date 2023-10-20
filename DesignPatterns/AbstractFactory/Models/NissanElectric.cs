using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class NissanElectric : IElectric
    {
        public string Accelerate()
        {
            return "Vrooom => Nissan";
        }

        public string Brake()
        {
            return "Screech => Nissan";
        }

        public string Recharge()
        {
            return "Recharging... => Nissan";
        }
    }
}

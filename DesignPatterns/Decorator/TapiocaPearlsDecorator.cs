using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TapiocaPearlsDecorator : BobaTeaDecorator
    {
        public TapiocaPearlsDecorator(IBobaTea bobaTea) : base(bobaTea)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, tapioca pearls";
        }
    }
}

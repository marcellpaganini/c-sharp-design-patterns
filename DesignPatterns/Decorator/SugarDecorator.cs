using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SugarDecorator : BobaTeaDecorator
    {
        public SugarDecorator(IBobaTea bobaTea) : base(bobaTea)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.3;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, sugar";
        }
    }
}

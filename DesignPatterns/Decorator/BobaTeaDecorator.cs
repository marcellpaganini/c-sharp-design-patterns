using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BobaTeaDecorator : IBobaTea
    {
        protected IBobaTea _bobaTea;

        public BobaTeaDecorator(IBobaTea bobaTea)
        {
            this._bobaTea = bobaTea;
        }

        public virtual double GetCost()
        {
            return this._bobaTea.GetCost();
        }

        public virtual string GetDescription()
        {
            return this._bobaTea.GetDescription();
        }
    }
}

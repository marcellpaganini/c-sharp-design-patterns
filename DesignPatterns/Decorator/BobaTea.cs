using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BobaTea : IBobaTea
    {
        public double GetCost()
        {
            return 1.0;
        }

        public string GetDescription()
        {
            return "Regular Boba Tea";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DiscountHandler : IRequestHandler
    {
        public void HandleRequest(Request request)
        {
            if (request.RequestType == RequestType.Discount)
            {
                Console.WriteLine("DiscountHandler handles the request.");
            }
            else
            {
                Console.WriteLine("DiscountHandler not handling request. End of the chain.");
            }
        }
    }
}

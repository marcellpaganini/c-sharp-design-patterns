using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class RetentionHandler : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public RetentionHandler(IRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(Request request)
        {
            if (request.RequestType == RequestType.Retention)
            {
                Console.WriteLine("RetentionHandler handles the request");
            }
            else
            {
                Console.WriteLine("RetentionHandler passes the request to the next handler.");
                _nextHandler?.HandleRequest(request);
            }
        }
    }
}

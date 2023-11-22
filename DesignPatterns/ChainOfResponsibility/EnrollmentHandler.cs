using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EnrollmentHandler : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public EnrollmentHandler(IRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(Request request)
        {
            if (request.RequestType == RequestType.Enrollment)
            {
                Console.WriteLine("EnrollmentHandler handles the request");
            }
            else
            {
                Console.WriteLine("EnrollmentHandler passes the request to the next handler.");
                _nextHandler.HandleRequest(request);
            }
        }
    }
}

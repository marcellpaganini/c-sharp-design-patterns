using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Request
    {
        public RequestType RequestType { get; set; }

        public Request(RequestType requestType)
        {
            RequestType = requestType;
        }
    }
}

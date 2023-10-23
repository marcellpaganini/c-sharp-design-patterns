using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class XMLBasedLibrary : IExternalLibrary
    {
        public void DisplayXML(string fileName)
        {
            Console.WriteLine($"Displaying {fileName}.xml");
        }
    }
}

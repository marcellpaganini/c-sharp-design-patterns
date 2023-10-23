using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class JsonBasedLibrary : IJsonBasedLibrary
    {
        public void DisplayData(string fileName)
        {
            Console.WriteLine($"Displaying {fileName}.json");
        }
    }
}

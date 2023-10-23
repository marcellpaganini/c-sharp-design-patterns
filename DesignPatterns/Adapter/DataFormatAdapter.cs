using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DataFormatAdapter : IJsonBasedLibrary
    {
        private IExternalLibrary _library;

        public DataFormatAdapter()
        {
            _library = new XMLBasedLibrary();
        }

        public void DisplayData(string fileName)
        {
            _library.DisplayXML(fileName);
        }
    }
}

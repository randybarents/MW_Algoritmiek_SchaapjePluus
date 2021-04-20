using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmiek_SchaapjePluus
{
    class Program
    {
        static void Main(string[] args)
        {
            IOHandler handler = new IOHandler();
            Pluus pluus = new Pluus();
            pluus.CountNumbers();
        }
    }
}

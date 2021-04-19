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
            handler.ReadNumbers();
            foreach (var number in handler.Numbers)
            {
                Console.WriteLine(number);
            }
            handler.WriteTestCase(3, "insomnia");
        }
    }
}

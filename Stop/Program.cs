using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            stoplicht stoplicht = new stoplicht();

            Console.WriteLine(stoplicht.GetCurrentColor());
            stoplicht.NextState();

            Console.WriteLine(stoplicht.GetCurrentColor());
            stoplicht.NextState();

            Console.WriteLine(stoplicht.GetCurrentColor());
            stoplicht.NextState();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            int d = 1;
            for (; a <=b; a++)
            d*= a;
            Console.WriteLine(d);
        }
    }
}

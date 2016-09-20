using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()),b=int.Parse(Console.ReadLine()),res=0;
            for (; a <=b; a++)
                res += a * a;
            Console.WriteLine(res);
        }
    }
}

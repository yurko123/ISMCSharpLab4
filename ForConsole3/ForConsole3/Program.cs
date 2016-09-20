using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine()),res=1;
            uint n=uint.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                res*= a;
            Console.WriteLine(res);
        }
    }
}

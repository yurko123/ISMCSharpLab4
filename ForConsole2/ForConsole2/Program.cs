using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        { uint N =uint.Parse(Console.ReadLine());
        double a = 0;
        for (int i = 1; i <= N; i++) 
        a += 1.0 / i;
        Console.WriteLine(a);
        }
       
    }
}

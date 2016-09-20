using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()),fact=1,res=0;
            for (int i = 1; i <= N; i++)
            {
                fact *= i;
                res += fact;
                
            }
            Console.WriteLine(res);
        }
    }
}

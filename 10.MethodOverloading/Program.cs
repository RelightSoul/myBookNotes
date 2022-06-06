using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****");
            Console.WriteLine(Add(10,10));
            Console.WriteLine(Add(5.43,7.55));
            Console.WriteLine(Add(454_654_344,233_554_233));
            
            Console.ReadLine();
        }

        static int Add(int x, int y)
        { return x + y; }

        static double Add(double x, double y)
        { return x + y; }

        static long Add(long x, long y)
        { return x + y; }
    }
}

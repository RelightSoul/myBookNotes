using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.SimpleUtilityClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Classes *****");

            TimeUtilClass.PrintTime();
            TimeUtilClass.PrintDate();

            Console.ReadLine();
        }
    }
}

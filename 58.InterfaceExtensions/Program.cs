using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.InterfaceExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Extending Interface Compatible Types *****\n");

            string[] data = {"wow","this","is","sort","of","annoying","but","in","a","weird","way","fun!" };
            data.PrintDataBeep();
            Console.WriteLine();

            List<int> myInts = new List<int> { 10, 15, 20 };
            myInts.PrintDataBeep();

            Console.ReadLine();

        }
    }
}

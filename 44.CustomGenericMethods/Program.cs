using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.CustomGenericMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Methods *****");
            int a = 10; int b = 90;
            Console.WriteLine($"{a} : {a.GetType()} , {b} : {b.GetType()}");
            MyGenericMethods.Swap<int>(ref a,ref b);
            Console.WriteLine($"{a} : {a.GetType()} , {b} : {b.GetType()}");

            Console.ReadLine();
        }        
    }
}

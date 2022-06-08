using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.SimpleDispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Dispose!");
            MyResourceWrapper rw = new MyResourceWrapper();
            rw.Dispose();
            Console.ReadLine();
        }
    }
}

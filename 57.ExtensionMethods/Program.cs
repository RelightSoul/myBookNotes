using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensionMethods;


namespace _57.ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Extension Methods :) *****\n");
            int myInt = 12345678;
            myInt.DisplayDefiningAssemble();

            System.Data.DataSet d = new DataSet();
            d.DisplayDefiningAssemble();            

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssemble();

            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Reversed digits of myUnt: {0}", myInt.ReverseDigits());
            Console.ReadLine();
        }
    }
}

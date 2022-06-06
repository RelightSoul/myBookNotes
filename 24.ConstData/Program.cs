using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.ConstData
{
    class MyMathClass
    {   
        // значенине константы всегда присваиваются на моменте создания
        public const double PI = 3.14;

        // Поля только для чтения могут присваиваться
        // в конструкторах, но больше нигде, 
        public readonly double testPI;    // static readonly
        public MyMathClass()
        {
            testPI = 3.14;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine($"Value of PI is {MyMathClass.PI}");
            Console.WriteLine("Hello World");

            Console.ReadLine();
        }
    }
}

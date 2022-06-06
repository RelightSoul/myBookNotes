using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");

            Car myCar = new Car(80);

            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
            Console.WriteLine();

            MiniVan myVan = new MiniVan();
            myVan.Speed = 20;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

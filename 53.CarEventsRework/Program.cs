using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.CarEventsRework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += (sender, e) => { Console.WriteLine("{0} say {1}", c1.PetName, e.msg); };
            c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };
            c1.Exploded += (sender, e) => Console.WriteLine(e.msg);  //сокращённый

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();

        }
    }
}

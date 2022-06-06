using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.CustomEnumeratorWithYield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the Yield Keyword *****\n");
            Garage carLot = new Garage();
            foreach  (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName,c.CurrSpeed);
            }
            Console.WriteLine();

            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrSpeed);
            }
            Console.ReadLine();
        }
    }
}

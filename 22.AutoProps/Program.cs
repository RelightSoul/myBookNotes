using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.AutoProps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Properties *****");
            Car c = new Car();
            c.PetName = "Limra";
            c.Color = "Red";
            c.Speed = 60;
            c.DisplayStats();

            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Numbers of Cars: {0}", g.NumbersOfCars);
            Console.WriteLine(g.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}

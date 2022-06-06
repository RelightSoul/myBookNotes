using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SimpleClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // разместим и сконфигурируем объект
            Car myCar = new Car("Sammanta");
            //myCar.petName = "Porshe 911";
            //myCar.currSpeed = 90;

            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(10);
                myCar.PrintState();
            }

            Motorcycle myMoto = new Motorcycle();
            myMoto.PopAWheelly();

            Console.WriteLine();
            myMoto.setDriverName("Tinny");
            Console.WriteLine($"Driver name: {myMoto.name}");
            Console.WriteLine();

            Motorcycle3 myNewMoto = new Motorcycle3(5);
            myNewMoto.setDriverName("Polly");
            myNewMoto.PopAWheelly();

            Console.WriteLine($"Intensity : {myNewMoto.driverIntensity}, Name : {myNewMoto.driverName}");

            Console.ReadLine();
        }        
    }
}

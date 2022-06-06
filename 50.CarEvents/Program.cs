using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.CarEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");

            Car c1 = new Car("Slugbug", 100, 10);

            // Зарегистрировать обработчики событий
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            //EventHandler<CarEventArgs> d =new EventHandler<CarEventArgs>(CarExploded);
            //c1.Exploded += d;
            c1.Exploded += CarExploded;
            Console.WriteLine("Speed up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.WriteLine();

            c1.AboutToBlow -= CarExploded;

            Console.WriteLine("Speed up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }

        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine("{0} say {1}", c.PetName, e.msg);
            }
        }
        public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        { Console.WriteLine("=> Critical Message from {0}: {1}", sender, e.msg); }
        public static void CarExploded(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine("{0} say {1}", c.PetName, e.msg);
            }
        }
    }
}
    /// ИмяОбъекта.ИмяСобытия += new СвязанныйДелегат(функцияДляВызова);
    ////
    //Car.CarEngineHandler d = new Car.CarEngineHandler(CarExplodedEventHandler);
    //myCar.Exploded += d;
    
            //НекоторыйТип t = new НекоторыйТип();
            //t.НекотороеСобытие +=
            //delegate (необязательноУказываемыеАргументыДелегата)
            //{ /* операторы */ };


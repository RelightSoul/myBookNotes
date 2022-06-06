using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.CarDelegateMethodGroupConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.RegisterWithCarEngine(CallMeHere);
            Console.WriteLine("Speeding up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            c1.UnRegisterWithCarEngine(CallMeHere);
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            
            Console.ReadLine();
        }        

        static void CallMeHere (string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }
    }
    // Этот обобщенный делегат может вызывать любой метод, который
    // возвращает void и принимает единственный параметр типа Т.
    public delegate void MygeneticDelegate<T>(T arg);
}

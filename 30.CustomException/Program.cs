using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Rusty", 0);
            for (int i = 0; i < 5; i++)
            {

                try
                {
                    myCar.Accelerate(20);
                }
                catch (CarIsDeadException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.ErrorTimeStamp);
                    Console.WriteLine(e.CauseOfError);
                }
            }
            
            
            Console.ReadLine();
        }
    }
}

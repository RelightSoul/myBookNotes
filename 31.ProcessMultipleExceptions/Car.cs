using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.ProcessMultipleExceptions
{
    partial class Car
    {           
        public void Accelerate(int delta)
        {
            if (delta<0)
            {
                // после throw идёт обявление исключения ключ + значение
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            }
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrSpeed += delta;
                if (CurrSpeed >= MaxSpeed)
                {
                    CurrSpeed = 0;
                    carIsDead = true;
                    CarIsDeadException ex = new CarIsDeadException
                ($"{PetName} has overheated", "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRus.com";
                    throw ex;
                }
                else
                    Console.WriteLine("=> Current Speed = {0}", CurrSpeed);
            }
        }

        }

}

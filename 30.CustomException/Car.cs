using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.CustomException
{
    internal class Car
    {
        // костанта максимальной скорости
        public const int MaxSpeed = 100;
        // свойства со значениями по умолчанию
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        // переменная проверки работы машины
        private bool carIsDead;
        //В автомобиле есть радиоприёмник
        private Radio mRadio = new Radio();
        //Конструкторы        
        public Car(string name, int speed)
        {
            CurrSpeed = speed;
            PetName = name;
        }
        public Car() { }
        // methods
        public void CrankTunes(bool state)
        {
            // Делегировать запрос к радио
            mRadio.TurnOn(state);
        }
        //public void Accelerate(int delta)
        //{
        //    CarIsDeadException ex = new CarIsDeadException
        //        ($"{PetName} has overheated","You have a lead foot",DateTime.Now);
        //    ex.HelpLink = "http://www.CarsRus.com";
        //    throw ex;
        //}
        public void Accelerate(int delta)
        {
            if (carIsDead)
            { Console.WriteLine("{0} is out of order...", PetName); }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.SimpleException
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
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...",PetName);
            }
            else
            {
                CurrSpeed += delta;
                if (CurrSpeed>=MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated!", PetName);
                    CurrSpeed = 0;
                    carIsDead = true;
                    // Мы хотим обращаться к свойству HelpLink, поэтому необходимо
                    // создать локальную переменную перед генерацией объекта Exception.
                    Exception ex = new Exception($"{PetName} is overheated!");
                    ex.HelpLink = "http://www.CarsRus.com";  // объявляется перед throw
                    //предоставить специальные данные, пары ключ/данные
                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}"); 
                    ex.Data.Add("Cause", "You have a lead foot.");
                    //throw ключевое своло для генерации исключения
                    throw ex;

                }
                else
                {
                    Console.WriteLine("=> Current Speed = {0}", CurrSpeed);
                }
            }
        }


    }

}

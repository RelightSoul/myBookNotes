using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.ComparableCar
{
    internal class Car : IComparable
    {        
        public const int MaxSpeed = 100;       
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";  
        public int CarID { get; set; }  

        public static IComparer SortByPetName
        {
            get 
            {
                return (IComparer)new PetNameComparer();
            }
        }

        private bool carIsDead;        public Car(string name, int speed, int id)
        {
            CurrSpeed = speed;
            PetName = name;
            CarID = id;  
        }
        public Car() { }
        
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

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp!=null)
            {
                //return this.CarlD.CompareTo(temp.CarlD);
                if (this.CarID > temp.CarID)
                {
                    return 1;
                }
                if (this.CarID < temp.CarID)
                {
                    return -1;
                }
                else
                    return 0;
            }
            else
            {
                throw new ArgumentException("Paramete is not a Car!");
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.AutoProps
{
    internal class Car
    {
        // Автоматические свойства! Нет нужды определять поддерживающие поля
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        // можно public int OnlyReady { get; }
        // нельзя public int OnlyWrite { set; }
        public void DisplayStats()
        {
            Console.WriteLine("Name : {0}", PetName);
            Console.WriteLine("Speed : {0}", Speed);
            Console.WriteLine("Color : {0}", Color);
        }

        //public string PetName { get; set; }  ==
        //public int PetName
        //{
        //    get { return carName; }
        //    set { carName = value; }
        //}
    }
}

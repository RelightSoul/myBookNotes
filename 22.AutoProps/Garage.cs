using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.AutoProps
{
    internal class Garage
    {
        public int NumbersOfCars { get; set; }  = 1;       //0
        public Car MyAuto { get; set; } = new Car();       //null
        // Для переопределения стандартных значений, присвоенных скрытым
        // поддерживающим полям, должны использоваться конструкторы
        public Garage()
        {
                                                           //MyAuto = new Car();
                                                           //NumbersOfCars = 1;
        }
        public Garage(int number, Car car)
        {
            NumbersOfCars = number;
            MyAuto = car;        
        }
    }
}

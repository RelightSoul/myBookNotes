using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SimpleClassExample
{
    internal class Car
    {
        // public-открытый privare-закрытый protected-защищённый
        public string petName;
        public int currSpeed;

        // специальный стандартный конструктор
        public Car()
        { 
            petName = "Lussi";
            currSpeed = 70; 
        }
        // дополнительные конструкторы (перегрузка)
        public Car(string pn) => petName = pn;            //=> сахар, сжимает однострочные методы, кострукторы 

        public Car(string pn,int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.",petName,currSpeed);   // => == {} в методе
        
        public void SpeedUp(int delta)
            => currSpeed += delta;
    } 
}

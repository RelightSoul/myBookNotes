using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.BasicInheritance
{
    internal class Car
    {   //поля
        public readonly int maxSpeed;
        private int currSpeed;
        //конструктор
        public Car(int max)
        { maxSpeed = max; }
        public Car() { maxSpeed = 55; }
        //свойства
        public int Speed 
        { 
            get {return currSpeed; }
            set {
                currSpeed = value;
                if (currSpeed>maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            } 
        }
    }
}

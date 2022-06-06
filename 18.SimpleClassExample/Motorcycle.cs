using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SimpleClassExample
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string name;                         // driverName

        public void setDriverName(string name)
        {
            this.name = name;                       // this.driverName
        }

        public void PopAWheelly()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeee Haaaaewww!");
            }
        }
        public Motorcycle() { }   // ctor tab+tab

        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

    }
}

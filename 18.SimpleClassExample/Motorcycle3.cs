using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SimpleClassExample
{
    internal class Motorcycle3
    {
        public int driverIntensity;
        public string driverName;

        public void setDriverName(string name)
        {
            driverName = name;                       // this.driverName
        }

        // Главный конструктор
        public Motorcycle3(int intensity = 0, string name = "")   // необязательные аргументы
        {
            Console.WriteLine("In master ctor ");
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }

        public void PopAWheelly()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeee Haaaaewww!");
            }
        }
    }
}

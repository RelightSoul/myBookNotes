using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SimpleClassExample
{
    internal class Motorcycle2
    {
        public int driverIntensity;
        public string driverName;
        
        public void setDriverName(string name)
        {
            driverName = name;                       // this.driverName
        }

        // Главный конструктор
        public Motorcycle2(int intensity, string name)
        {
            Console.WriteLine("In master ctor ");
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }
        
        // Связывание дополнительных кострукторов в цепочку
        public Motorcycle2() => Console.WriteLine("In default ctor");
        public Motorcycle2(int intensity) :this(intensity,"")=> Console.WriteLine("In ctor taking an int");
        public Motorcycle2(string name) : this(0, name) => Console.WriteLine ("In ctor taking a string");


        public void PopAWheelly()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeee Haaaaewww!");
            }
        }

    }
}

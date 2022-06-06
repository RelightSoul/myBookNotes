using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _37.CustomEnumerator
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage ()
        {
            carArray[0]= new Car("Rusty",30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }
        //если вы предпочитаете скрыть функциональность IEnumerable на
        //уровне объектов, то просто примените явную реализацию интерфейса
        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}

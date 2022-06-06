using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _38.CustomEnumeratorWithYield
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
        public IEnumerator GetEnumerator()
        {
            // Исключение не сгенерируется до тех пор, пока не будет вызван метод MoveNext
            //throw new Exception("This will get called");
            return actualImplementation();
            IEnumerator actualImplementation() 
            { 
            foreach (Car c in carArray)
                {
            //Ключевое слово yield применяется для указания значения
            //или значений, которые подлежат
            //возвращению конструкцией foreach вызывающему коду                    
                                    yield return c;
                }
            }
        //yield return carArray[0];
        //yield return carArray[1];
        //yield return carArray[2];
        //yield return carArray[3];
        }
        public IEnumerable GetTheCars(bool returnReversed)
        {
            return actualImplementation();
            IEnumerable actualImplementation()
            {
                if (returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                {
                    foreach (Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}

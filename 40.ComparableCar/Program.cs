using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.ComparableCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusky",80,1);
            myAutos[1] = new Car("Marry",40,234);
            myAutos[2] = new Car("Viper",40,34);
            myAutos[3] = new Car("Mel",40,4);
            myAutos[4] = new Car("Chucky",50,5);
            Console.WriteLine(" here is the unordered set of cars: ");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID,c.PetName);
            }

            //Cортировать по ID
            //Array.Sort(myAutos)

            //Теперь сортировать по дружественному имени.
            Array.Sort(myAutos, Car.SortByPetName); 
            Console.WriteLine();

            Console.WriteLine("Here is ordered set of cars: ");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }

            Console.ReadLine();
        }
    }
}

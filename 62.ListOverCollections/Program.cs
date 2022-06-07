using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.ListOverCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");
            List<Car> myCars = new List<Car>()
            {
                new Car {PetName ="Henry",Color="Silver",Speed=100,Make="BMW" },
                new Car {PetName="Daisy",Color="Tan",Speed=90,Make="BMW"},
                new Car {PetName="Mary",Color="Black",Speed=55,Make="VW"},
                new Car {PetName="Clunker",Color="Rust",Speed=5,Make="Yugo"},
                new Car {PetName="Melvin",Color="White",Speed=43,Make="Ford"}
            };
            GetFastCars(myCars);
            Console.WriteLine();
            LINQOverArrayList();
            Console.WriteLine();
            OfTypeAsFilter();
            Console.ReadLine();
        }
        static void GetFastCars(List<Car> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 50 && (c.Make =="BMW"||c.Make=="VW") select c;
            foreach (var c in fastCars)
            {
                Console.WriteLine(c.PetName);
            }
        }
        static void LINQOverArrayList()
        {   // необобщенные коллекции
            ArrayList myCars = new ArrayList()
            {
                new Car {PetName ="Henry",Color="Silver",Speed=100,Make="BMW" },
                new Car {PetName="Daisy",Color="Tan",Speed=90,Make="BMW"},
                new Car {PetName="Mary",Color="Black",Speed=55,Make="VW"},
                new Car {PetName="Clunker",Color="Rust",Speed=5,Make="Yugo"},
                new Car {PetName="Melvin",Color="White",Speed=43,Make="Ford"}
            };
            // Трансформировать ArrayList в тип, совместимый c IEnumerable<T>.
            var myCarsEnum = myCars.OfType<Car>();   // OfType фильтрует элементы на основе IEnumerable<T>
            var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
            foreach (var c in fastCars)
            {
                Console.WriteLine(c.PetName);
            }
        }
        static void OfTypeAsFilter()
        {
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] {10,400,8,false,new Car(),"string data" });
            var myInts = myStuff.OfType<int>();
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }
    }
}

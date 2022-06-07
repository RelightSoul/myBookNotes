using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59.AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new { Color="Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            Console.WriteLine("myCar: {0} {1}",myCar.Color,myCar.Make);
            Console.WriteLine("\nAnother new car: ");
            BuildAnonType("Porsche","Red",140);
            Console.WriteLine();
            ReflectOverAnonymousType(myCar);
            Console.WriteLine();
            EqualityTest();
            Console.WriteLine();
            // Анонимный тип состоящий из анонимного типа
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 },
                Price = 34.000
            };
            ReflectOverAnonymousType(purchaseItem);
            Console.ReadLine();
        }
        static void BuildAnonType (string make, string color, int currSP)
        {
            //Построение анонимного типа с применением входных элементов
            var car = new { Make = make, Color = color, Speed = currSP };
            //можно объявлять через анон.тип
            Console.WriteLine("You have a {0} {1} going {2} MPH",car.Color,car.Make,car.Speed);
            Console.WriteLine("ToString() == {0}",car.ToString());
        }
        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is a instance of {0}",obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}",
                obj.GetType().Name,
                obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}",obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}",obj.GetHashCode());
            Console.WriteLine();
        }
        static void EqualityTest()
        {
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            if (firstCar.Equals(secondCar))                 //Equals сравнивает значение каждого поля
                Console.WriteLine("Same objects");           
            else
                Console.WriteLine("Not the same!!");
            if (firstCar==secondCar)                        //Сравнивает ссылки
                Console.WriteLine("Same objects");
            else
                Console.WriteLine("Not the same!!");
            if (firstCar.GetType().Name == secondCar.GetType().Name) //Сравнивает наборы свойств
                Console.WriteLine("Same type");
            else
                Console.WriteLine("Different type");
            Console.WriteLine();
            ReflectOverAnonymousType(firstCar);
            ReflectOverAnonymousType(secondCar);
        }
    }
}

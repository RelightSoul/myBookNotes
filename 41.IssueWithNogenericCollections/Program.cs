using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.IssueWithNogenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 25;
            object boxedMyInt = myInt;
            int unboxedMyInt = (int)boxedMyInt;

        }
        static void UseGeneticList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");

            //// Этот объект List<> может хранить только объекты Person.
            //List<Person> morePeople = new List<Person>();
            //morePeople.Add(new Person("Frank", "Black", 50));
            //Console.WriteLine(morePeople[0]);
            //// Этот объект Listo может хранить только целые числа.
            //List<int> moreInts = new List<int>();
            //moreInts.Add(10);
            //moreInts.Add(2);
            //int sum = moreInts[0] + moreInts[1];
            //// Ошибка на этапе компиляции! Объект Person
            ////не может быть добавлен в список элементов int!
            //// moreInts.Add(new Person());
            ///

            // Инициализация стандартного массива.
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Инициализация обобщенного List<> с элементами int.
            List<int> myGenericList = new List<int> { 1,2,3,4,5,6,7,8,9};

            // Инициализация ArrayList числовыми данными.
            ArrayList myList = new ArrayList { 1,2,3,4,5,6,7,8,9};

            
            
            //List<Point> myListPoints = new List<Point>
            //{
            //    new Point {X = 2, Y = 4},
            //    new Point {X = 3, Y = 1},
            //    new Point (PointColor.BloodRed){X = 2, Y = 4},
            //};
            //foreach (var pt in myListPoints)
            //{
            //    Console.WriteLine(pt);
            //}
        }
    }
}
    

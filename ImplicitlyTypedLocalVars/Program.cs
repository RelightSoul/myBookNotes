using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImplicitlyTypedLocalVars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitVars();
            LinqQueryInts();

            Console.ReadLine();
        }
        static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Kiss me!!";
            Console.WriteLine("myInt type is: {0}", myInt.GetType());
            Console.WriteLine("myBool type is: {0}", myBool.GetType());
            Console.WriteLine("myString type is: {0}", myString.GetType());

            //  Допустимо, если SportsCar имеет ссылочный тип!
            //  var myCar = new SportsCar();
            //  myCar = null;
           
            // Также нормально!
            //var myInt = 0;
            //var anotherInt = myInt;
            //string myString = "Wake up!";
            //var myData = myString;

        }
        static void LinqQueryInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // Запрос LINQ!
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Value in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine();

            Console.WriteLine("subset is a :{0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();   

            Console.ReadLine();
        }
        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)  
            {
                Console.WriteLine("Number is: {0}", i);
            }
        }
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            int[] myInts = { 10, 20, 30, 40 };
            foreach (var i in myInts)
            {
                Console.WriteLine(i);
            }           
        }
        static void WhileLoopExample ()
        {
            string userIsDone = "";
            //Проверить копию строки в нижнем регистре.
            while (userIsDone.ToLower()!="yes")
            {
                Console.WriteLine("In while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");                
                userIsDone = Console.ReadLine();
            }
        }
        // do while обязательно выполниться хотябы один раз.
        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone= Console.ReadLine(); 
            } 
            while (userIsDone.ToLower()!="yes");
        }
    }
}

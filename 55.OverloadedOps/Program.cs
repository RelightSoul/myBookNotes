using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.OverloadedOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Point ptThree = ptOne + ptTwo;
            Console.WriteLine(ptThree);
            Console.WriteLine();
            Point ptFour = ptOne + 10;
            Console.WriteLine(ptFour);
            Console.WriteLine();
            //автоматически эмулируются в случае перегрузки связанных бинарных операций
            Console.WriteLine(ptThree += ptFour);
            Console.WriteLine(ptOne -= ptTwo);
            Console.WriteLine();
            // вывелось, потом изменилось
            Console.WriteLine(ptTwo++);
            // изменилось и вывелось
            Console.WriteLine(++ptTwo);
            Console.WriteLine();
            Console.WriteLine("ptOne == ptTwo : {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo : {0}", ptOne != ptTwo);
            Console.WriteLine();
            Console.WriteLine(ptOne<ptFour);


            Console.ReadLine();
        }
    }
}

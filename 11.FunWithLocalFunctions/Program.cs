using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FunWithLocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(Add(4, 8));
            Console.WriteLine(AddWrapper(8, 12));

            Console.ReadLine();
        }

        //static int Add(int x, int y)
        //    { return x + y;}  
        
        static int AddWrapper(int x, int y)
        {
            return Add();
            int Add()
            { return x + y; }
        }
        

    }
}

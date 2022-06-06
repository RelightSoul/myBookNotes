using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.SimpleDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryOp b = new BinaryOp(SimpleMath.Add);
            DisplayDelegateInfo(b);
            Console.WriteLine("10 + 10 is {0}",b(10,10));
            Console.ReadLine();
        }
        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name: {0}", d.Method);
                Console.WriteLine("Type name: {0}", d.Target);
            }
        }
    }
    public delegate int BinaryOp(int x, int y);
    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
    }
   
}

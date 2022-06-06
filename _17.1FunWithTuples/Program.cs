using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1FunWithTuples
{
    internal class Program
    {
        struct Point
        {
            public int X;
            public int Y;

            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos; 
            }

            public (int XPos, int YPos) Deconstruct() => (X, Y);
        }
        static void Main(string[] args)
        {
            int a;
            string c;
            bool b;

            FillThereValues(out a, out c, out b);
            Console.WriteLine($"{a},{c},{b}");
            Console.WriteLine();

            FillthereValues2();
            Console.WriteLine($"{a},{c},{b}");
            Console.WriteLine();
            var samples = FillthereValues2();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.c}");
            Console.WriteLine($"Bool is: {samples.b}");

            var split = SplitNames("Vladislav Barayschuck Alexanrovich");
            Console.WriteLine($"First: {split.first}");
            Console.WriteLine();

            Point lt = new Point(3, 7);
            var pointValue= lt.Deconstruct();
            Console.WriteLine($"{pointValue.XPos}");
            Console.WriteLine($"{pointValue.YPos}");


            Console.ReadLine();
        }

         static void FillThereValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        static (int a,string c,bool b) FillthereValues2()
        {
            return (9, "Enjoy your string", true);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
            return ("Vladislav", "Barayschuck", "Alexanrovich");
        }

    }
}

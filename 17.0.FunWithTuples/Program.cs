using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.FunWithTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Кортеж, позиции кортежа считаются с 1
            (string, int, string) values = ("a", 5, "c");
                       
            Console.WriteLine($"First item: {values.Item1}");              
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");
            Console.WriteLine();

            (string FirstLetter, int TheNumber, string SecondLetter)
                valuesWithNames = ("a", 5, "c");
            
            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            Console.WriteLine();
            Console.WriteLine($"First item: {valuesWithNames.Item1}");
            Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            Console.WriteLine($"Third item: {valuesWithNames.Item3}");
            Console.WriteLine();
            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

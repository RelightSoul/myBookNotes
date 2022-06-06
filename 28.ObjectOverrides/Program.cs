using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.ObjectOverrides
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Objects *****\n");
            
            Person p1 = new Person();
            p1.FirstName = "Sam";
            p1.LastName = "Mauer";
            p1.Age = 25;
            Console.WriteLine("To string: {0}",p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine($"Type: {p1.GetType()}");
            
            Person p2 = p1;
            object o = p2;
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }
            char a = 'а';
            char b = 'б';
            char c = 'в';
            char d = 'г';
            Console.WriteLine($"{a.GetHashCode()}");
            Console.WriteLine($"{b.GetHashCode()}");
            Console.WriteLine($"{c.GetHashCode()}");
            Console.WriteLine($"{d.GetHashCode()}");



            Console.ReadLine();
        }
    }
}

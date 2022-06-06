using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.SimpleLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TraditionalDelegateSyntax();
            //AnonymousMethodSyntax();
            LambdaExpressionSyntax();

            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int i in evenNumbers)
            {
                Console.Write("{0}\t",i);
            }
            Console.WriteLine();
        }
        static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;    
        }

        static void AnonymousMethodSyntax ()
        {
            // Создать список целочисленных значений
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Использовать анонимный метод
            List<int> evenNumbers = list.FindAll(delegate (int i)
                { return (i % 2) == 0;} );
            Console.WriteLine("Here are your even numbers:");
            foreach (int i in evenNumbers)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
        static void LambdaExpressionSyntax()
        {
            List<int> list=new List<int> ();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });            

            //Используем лямбда-выражение
            //АргументыДляОбработки => ОбрабатывакяциеОператоры
            //List<int> evenNumbers = list.FindAll(i=>(i%2)==0);
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("Value of i is: {0}",i);
                bool isEven = ((i % 2) == 0); 
                return isEven;                
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int i in evenNumbers)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
    }
}

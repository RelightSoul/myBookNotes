using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NullableTypes
{
    internal class Program
    {
        class DatabaseReader
        {
            public int? numericValue = null;
            public bool? boolValue = true;

            public int? GetIntFromDatabase ()
            { return numericValue; }

            public bool? GetBoolFromDatabase()
            { return boolValue; }
        }

        static void Main(string[] args)
        {
            // \n перенос строки
            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //Получаем int из BD
            int? i = dr.GetIntFromDatabase()??100;  // ?? присвает значение, если переменная == null, то же самое что if (ImoreData.HasValue) moreData = 100;
            if (i.HasValue)   // HasValue имеет ли переменная значение
            {
                Console.WriteLine("Value of i: {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of i is undefined");   // undefined - неопределенно
            }
            
            //Получаем bool из BD
            bool? b = dr.GetBoolFromDatabase();
            if (b!=null)
            {
                Console.WriteLine("Value of b is {0}",b.Value);
            }
            else
            {
                Console.WriteLine("Value of b is undefined");
            }

            //Console.WriteLine();
            //// ? позволяет добавить null к переменным значимых типов, иначе это невозможно
            //// ? нельзя добавить к ссылочным типам
            //int? nullableInt = 10;
            //double? nullableDouble = 3.14;
            //bool? nullableBool = null;
            //char? nullableChar = 'a';
            //int?[] arrayOfNullableInts = new int?[10];

            Console.ReadLine();
        }

        //    ? == Nullable<T>

        //static void LocalNullableVariablesUssingNullable()
        //{
        //    Nullable<int> nullableInt = 10;
        //    Nullable<double> nullableDouble = 3.14;
        //    Nullable<bool> nullableBool = null;
        //    Nullable<int> nullableChar = 'a';
        //    Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        //}

        // Перед доступом к данным массива мы должны проверить его на равенство null!
        static void TestedMethod(string[] args)
        {
            if (args!=null)
                Console.WriteLine(@"You send me {args.Length} arguments.");
            //Console.WriteLine("You send me {0} arguments.",args.Length);

        }

        static void TestedMethod2(string[] args)
        {
            // Мы должны проверять на предмет null перед доступом к данным массива!
            Console.WriteLine(@"You send me {args?.Length} arguments.");
        }

        static void TestedMethod3(string[] args)
        {
            Console.WriteLine(@"You send me {args?.Length??0} arguments.");
        }
    }
}

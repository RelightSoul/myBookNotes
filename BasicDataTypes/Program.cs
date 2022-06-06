using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewingDataTypes();
            CharFunctionality();
            ParseFromString();
            ParseFromStringsWithTryParse();
            UseDatesAndTime();
            UseBigInteger();
            DigilSeparatos();
            BinaryLiterals();

            Console.ReadLine();
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            //типДанных имяПеременной = начальноеЗначение;
            int myInt = 0;            
            // Объявлять и присваивать можно также в двух отдельных строках.
            string myString;
            myString = "This is my charapter data";
            //Можно объявлять несколько переменных одного типа в одной строчке.
            bool b1 = true, b2 = false, b3 = b1;            
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", myInt,myString,b1,b2,b3);
            Console.WriteLine();            
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i=new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0},{1},{2},{3}",b,i,d,dt);
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionalite:");
            char myChar = 'a';
            Console.WriteLine("Char.IsDigit ('a') : {0}", char.IsDigit(myChar));
            Console.WriteLine("Char.IsLetter ('a') : {0}", char.IsLetter(myChar));
            Console.WriteLine("Char.IsLetter ('Hello There',5) : {0}", char.IsWhiteSpace("Hello There",5));
            Console.WriteLine("Char.IsLetter ('Hello There',6) : {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation(’?'): {0}",char.IsPunctuation('?'));

        }
        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b =bool.Parse("True");
            Console.WriteLine("Value of b: {0}",b);
            double d = double.Parse("99,554");
            Console.WriteLine("Value of d: {0}",d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}",i);
            char c = char.Parse("G");
            Console.WriteLine("Value of c: {0}",c);
        }
        //TryParse  if/else
        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("False", out bool b))
            {               
                Console.WriteLine("Value of b: {0}",b);
            }
            string value = "7,44";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d:{0}",d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double",value);
            } 
        }
        static void UseDatesAndTime()
        {
            Console.WriteLine("=> Dates and Times:");
            //Этот коструктор принимает год, месяц и день.
            DateTime dt = new DateTime(2022, 05,24);
            // Какой это день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date,dt.DayOfWeek);
            // Сейчас месяц декабрь.
            dt  =   dt.AddDays(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // Коструктор принимает часы, минуты и секунды.
            TimeSpan ts = new TimeSpan(4, 30, 10);
            Console.WriteLine(ts);
            // Вычесть 16минут из текущего значения TimeSpan  и вывести результат.
            Console.WriteLine(ts.Subtract(new TimeSpan(0,16,0)));
        }
        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy =
                BigInteger.Parse("999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);// значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven); 
            Console.WriteLine("Is biggy a power of two?: {0}",biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("44444444444444"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig); 
            BigInteger reallyBig2 = reallyBig * biggy;
            Console.WriteLine(reallyBig2);
        }
        static void DigilSeparatos()
        {
            Console.WriteLine("=> Use Digil Sparators:");
            Console.WriteLine("Integer:");
            Console.WriteLine(123_456);
            Console.WriteLine("Long:");
            Console.WriteLine(123_456_234L);
            Console.WriteLine("Float");
            Console.WriteLine(133_456.24323F); 
            Console.WriteLine("Double");
            Console.WriteLine(133_534.3452);
            Console.WriteLine("Decimal");
            Console.WriteLine(432_123.543_4M);
        }
        private static void BinaryLiterals()
        {
            Console.WriteLine("=>Use Binary Literals:");
            Console.WriteLine("Sixteen: {0}",0b0001_0000);
            Console.WriteLine("Thirty Two: {0}",0b0010_0000);
            Console.WriteLine("Sixty four: {0}", 0b0100_0000);
        }              

    }
}

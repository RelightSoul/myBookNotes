using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.FunWithEnums
{
    internal class Program
    {
        enum EmpType  //  :   byte,long,double,....
        {
            Manager,         // = 0     Manager=108     Manager = 11,
            Grunt,           // = 1     = 109           Grunt = 2,
            Contractor,      // = 2     = 110           Contractor = 105,
            VicePresident    // = 3     = 111           VicePresident = 53
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Enums *****");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            // Вывести тип хранилища для значений перечислений
            Console.WriteLine("EmpType is : {0}",Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("EmpType is : {0}", Enum.GetUnderlyingType(typeof(EmpType))); //typeof не требует объявление переменной

            Console.WriteLine("{0} = {1}",emp.ToString(),(int)emp);
            Console.WriteLine();

            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Cyan;

            EvaluateEnum(cc);
            EvaluateEnum(day);
            EvaluateEnum(emp);
            
            Console.ReadLine();
        }

        // Выводит детали любого перечисления
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}",e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}" , Enum.GetUnderlyingType(e.GetType()));

            //Получить все пары "имя-значение" для входного параметра
            Array enumData = Enum.GetValues(e.GetType());  // GetValuers возращает массив Enum-а
            Console.WriteLine("This enum has {0} members", enumData.Length);
            //Вывести имя + значение
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",enumData.GetValue(i));
            }
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You are got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You are get enough cast");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Offcause SIR!");
                    break;               
            }
        }

        
    }
}

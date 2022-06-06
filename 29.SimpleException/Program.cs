using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _29.SimpleException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Jolly",20);
            myCar.CrankTunes(true);

            try 
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");                //ошибка
                // TargetSite возвращает не простую строку, а строго
                // типизированный объект System.Reflection.MethodBase
                Console.WriteLine("Member: {0}", e.TargetSite);      //имя члена  
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType); //член
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType); //тип члена
                Console.WriteLine("Message: {0}", e.Message);        //сообщение
                Console.WriteLine("Source: {0}", e.Source);          //источник
                Console.WriteLine("Stack: {0}",e.StackTrace); //последовательность вызовов
                Console.WriteLine("Help link: {0}",e.HelpLink);
                Console.WriteLine("\n->Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("->{0}^ {1}", de.Key, de.Value);
                }
            }
            Console.WriteLine("\nOut of exception logic!");
            Console.WriteLine();
            
            
            Console.ReadLine();
        }
    }
}

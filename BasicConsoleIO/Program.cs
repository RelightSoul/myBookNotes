using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Bacis Console I/O *****");
            GetUserData();
            FormatNumerecalData();  
            Console.ReadLine();            
        }        
        private static void GetUserData()
        {            
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge= Console.ReadLine();            
            //Изменить цвет переднего плана консоли
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;                      
            Console.WriteLine("Hello {0}' You are {1} years old.", userName, userAge);
            //Восстановить предыдущий цвет переднего плана.
            Console.ForegroundColor=prevColor;                       
        }
        static void FormatNumerecalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Обратите внимание, что использование для символа шестнадцатеричного формата
            // верхнего или нижнего регистра определяет регистр отобраемых символов.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
       
        
    }
}

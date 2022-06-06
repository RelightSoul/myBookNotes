using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Operatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ifEsleExample();
            ExecuteIfElseUsingCinditionalOperator();
            SwitchExample();
            SwitchStringExample();
            SwitchOnEnumExample();
            ExecutePatternMatchingSwitch();
            ExecutePatternMatchingWithWhen();

            Console.ReadLine();
        }
        static void ifEsleExample ()
        {
            string data = "My string";
            if (data.Length>0)
            {
                Console.WriteLine("String greater than 0 charapters");
            }
            else
            {
                Console.WriteLine("String has no charapters");
            }
        }
        private static void ExecuteIfElseUsingCinditionalOperator()
        {
            string data = "";
            Console.WriteLine(data.Length > 0 ? "String greater than 0" : "String has no charapters");
            Console.WriteLine();
        }

        // &&  if (age == 30 && name =="Fred") , true если оба верны
        // &   if (age == 30 & name =="Fred") , даже если первый не верен, проверит второй
        // ||  if (age == 30 || name =="Fred"), true если один из верен
        // |   if (age == 30 | name =="Fred")
        // !   if (!myBool), возращает обратное значение если true то false, если false то true

        static void SwitchExample ()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language prefer: ");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice C#");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP and more!");
                    break ;
                default:
                    Console.WriteLine("Well done!");
                    break;                                         
            }
        }
        static void SwitchStringExample()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language prefer: ");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice C#");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP and more!");
                    break;
                default:
                    Console.WriteLine("Well done!");
                    break;
            }
        }
        static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favorite day of week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another shit day");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Next shit day after Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Day of games!!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Friday RULES!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day");
                    break;                   
            }
            Console.WriteLine();
        }
        static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Ingeter (5)], 2 [String (\"Hi\"), 3 [Decimal (2.5)]");
            Console.Write("Please chose an option: ");
            string userChoice = Console.ReadLine();
            object choice;
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5m;
                    break;
                default:
                    choice = 5;
                    break;
            }
            switch (choice)
            {
                    case int i:
                    Console.WriteLine("Your choice is integer: {0}",i);
                    break ;
                case string s:
                    Console.WriteLine("Your choice is string: {0}", s);
                    break;
                    case decimal d:
                    Console.WriteLine("Your choice is decimal: {0}", d);
                    break;
                default:
                    Console.WriteLine("Other choice ");
                    break;
            }
        }
        static void ExecutePatternMatchingWithWhen()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language prefer: ");
            object langChoice = Console.ReadLine();            
            var choice = int.TryParse(langChoice.ToString(),out int c) ? c : langChoice;
            switch (choice)
            {
                case int i when i==2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase) :
                    Console.WriteLine("VB: OOP and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice C#");
                    break;
                default:
                    Console.WriteLine("Well done!");
                    break;
            }
        }        
    }
}

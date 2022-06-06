using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.ActionAndFuncDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action<string, ConsoleColor, int> actionTarget =
            //     new Action<string, ConsoleColor, int>(DisplayMessage);
            Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
            actionTarget("Action Message!", ConsoleColor.Red, 5);
            Console.WriteLine();

            //Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40,40);
            Console.WriteLine(result);
            Console.WriteLine();

            Func<int, int, string> funcTarget2 = AddToString;
            string result2 = funcTarget2.Invoke(40, 40);
            Console.WriteLine(result);
            Console.WriteLine();

            Car myCar = new Car();
            myCar.listOfHandlers = new Car.CarEngineHandler(CallWhenExploded);
            myCar.Accelerate(10);

            myCar.listOfHandlers.Invoke("Hehehehe");

            Console.ReadLine();
        }
        static void CallWhenExploded(string msg)
        {
            Console.WriteLine(msg);
        }
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = previous;
        }
        static int Add(int x,int y)
        {
            return x + y;
        }

        static string AddToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
    
}

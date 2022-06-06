using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FunWithMetods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods ***** \n");

            //Передать две переменные по значению
            //int x = 9, y = 10;
            //Console.WriteLine("Before call : X: {0}, Y: {1}", x ,y);
            //Console.WriteLine("Answer is : {0}", Add(x, y));
            //Console.WriteLine("After call : X: {0}, Y:{1}",x,y);
            //Console.WriteLine();

            //int i; string str; bool b;
            //FillThereValues(out i, out str, out b);
            //Console.WriteLine("Int is: {0}", i);
            //Console.WriteLine("String is: {0}", str);
            //Console.WriteLine("Bool is: {0}", b);
            //Console.WriteLine();

            //string str1 = "Flip";
            //string str2 = "Flop";
            //Console.WriteLine("До применения метода: {0} + {1}",str1 ,str2);
            //RefStringSwap(ref str1,ref str2);
            //Console.WriteLine("После применения метода: {0} + {1}", str1, str2);
            //Console.WriteLine();

            //#region Ref locals and params
            //string[] stringArray = { "one", "two", "three" };
            //int pos = 1;
            //Console.WriteLine("=> Use Simple Return");
            //Console.WriteLine("Before:{0},{1},{2} ", stringArray[0], stringArray[1],stringArray[2]);
            //var output = SimpleReturn(stringArray,pos);
            //output = "new";
            //Console.WriteLine("After:{0},{1},{2} ", stringArray[0], stringArray[1], stringArray[2]);
            //#endregion

            #region Ссылочные локальные переменные и возвращаемые ссылочные значения
            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before:{0},{1},{2} ", stringArray[0], stringArray[1], stringArray[2]);
            ref var output = ref SimpleRefReturn(stringArray, pos);
            output = "new";
            Console.WriteLine("After:{0},{1},{2} ", stringArray[0], stringArray[1], stringArray[2]);
            Console.WriteLine();
            #endregion

            double average;
            average = CalcutaleAverage(4.0, 3.4, 5.7, 7.7);
            Console.WriteLine("Average: {0}", average );
            Console.WriteLine();

            double[] data = { 4.0, 3.4, 5.7, 7.7 };
            average = CalcutaleAverage(data);
            Console.WriteLine("Average: {0}", average);
            Console.WriteLine();

            Console.WriteLine("Average of data is: {0}", CalcutaleAverage());
            Console.WriteLine();

            EnterLogData("We can't find data!");
            EnterLogData("Go to Hell", "Devil");
            Console.WriteLine();

            DisplayFancyMessage(message: "WOW! Ghosts!!",
                textColor: ConsoleColor.Green,
                backgroudColor: ConsoleColor.Magenta);
            Console.WriteLine();
            DisplayFancyMessage(backgroudColor: ConsoleColor.White,
                message: "TESTing....",
                textColor: ConsoleColor.Red);
            Console.WriteLine();

            Console.ReadLine();
        }
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroudColor, string message)
        {
            //Сохраним старые цвета для их восстановления
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            //Установить новые цвета и вывести сообщение
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroudColor;
            Console.WriteLine(message);

            //Восстановить цвета
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;

        }

        static void EnterLogData(string message, string owner ="Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }


        // вернуть среднее из нескольких дробных значений
        static double CalcutaleAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length) ;

            double sum = 0;
            if (values.Length==0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }

        public static ref string SimpleRefReturn(string[] str, int pos)
        {
            return ref str[pos];
        }

        public static string SimpleReturn(string[] str,int pos)
        {
            return str[pos];
        }

        static void RefStringSwap(ref string str1,ref string str2)
        {
            string strSwaper= str1;
            str1 = str2;
            str2 = strSwaper;
        }

        static int Add(int x, int y)
        {
            int answer = x + y;
            x = 10000;
            y = 88888;
            return answer;
        }

        static void FillThereValues(out int a, out string b, out bool c)
        {
            a = 33;
            b = "Run FOREST run";
            c = true;
        }
    }
}

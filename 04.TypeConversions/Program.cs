using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShortSum();
            NarrowingAttempt();
            ProcessBytes();

            Console.ReadLine();
        }
        static short ShortSum()
        {
            Console.WriteLine("*****Fun with Conversions*****");                        
            short numb1 = 30000, numb2 = 30000;
            //  Явно привести int к short (разрешить потерю данных)
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0}+{1}={2}", numb1, numb2, answer);
            return answer;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void NarrowingAttempt()
        {
            byte myBite = 0;
            int myInt = 200;
            myBite=(byte)myInt;
            Console.WriteLine("Value of byte: {0}", myBite);               
        }
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine(sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            //try
            //{   checked
            //    {
            //        byte sum = (byte)Add(b1, b2);
            //        Console.WriteLine(sum);
            //    }
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //unchecked используется если включена проверка в свойствах, по аналогии с checked
            //для отмены проверки
        }
       
    }
}

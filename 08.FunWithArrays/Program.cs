using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FunWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArray();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();
            
            Console.ReadLine();
        }
        static void SimpleArray()
        {
            Console.WriteLine("=> Simple Array Creation:");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }
        static void DeclareImplicitArrays()
        {   //обязательно объявлять new, все элементы массива одного типа
            Console.WriteLine("=> Implicit Array Initialization: ");
            var a = new[] { 1, 3, 4, 5, 6 };
            Console.WriteLine("a is a: {0}", a.ToString());
            var b = new[] { 1, 3.3, 4, 5.8, 6.1 };
            Console.WriteLine("b is a: {0}", b.ToString());
            var c = new[] { "Hello", "Bye", "Kiss" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects: ");
            object[] MyObjects = new object[4];
            MyObjects[0] = 10;
            MyObjects[1] = false;  
            MyObjects[2] = new DateTime(1989,12,29);
            MyObjects[3] = "From & Void";
            foreach (object obj in MyObjects)
            {
                Console.WriteLine("Get type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimesional array.");
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            //Заполнить массив 3*4
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j; //перебираю все значения и перемножаю
                            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i,j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array. ");
            int[][] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Element {0} is {1}", i, myInts[i]);
            Console.WriteLine();
        }
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }
        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Передать массив в качестве параметра.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);
            // Получить массив как возвращаемое значение,
            string[] strs = GetStringArray();
            foreach (string s in strs)
            Console.WriteLine(s);
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            string[] gothicBands = { "Tones of tail", "Bauhaus", "Sisters of Mercy" };
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Array.Reverse(gothicBands); // массив с конца
            Console.WriteLine("=> Reversed array");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, gothicBands.Length-1);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }

        }
    }

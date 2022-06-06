using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FunWithStructures
{
    internal class Program
    {
        struct Point
        {   // Поля структуры
            public int X;
            public int Y;
            // Добавить 1 к позиции (X,Y)
            public void Increment()
            { X++; Y++; }
            public void Decrement()
            { X--; Y--; }   
            public void Display()
            { Console.WriteLine("X: {0}, Y: {1}",X,Y); } //Текущая позиция

            public Point(int Xpos, int Ypos)  // специальный конструктор
            { X = Xpos; Y = Ypos; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** A First look at Structures ***** \n");
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            myPoint.Decrement();
            myPoint.Display();
            Console.WriteLine();
            Point p1 = new Point();//присваивает стандартные значения
            p1.Display();
            Console.WriteLine();
            Point p2 = new Point(10, 30);
            p2.Display();
            Console.ReadLine();
        }
    }
}

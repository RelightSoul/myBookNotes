using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._0.ValueAndReferenceTypes
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
            { Console.WriteLine("X: {0}, Y: {1}", X, Y); } //Текущая позиция
            public Point(int Xpos, int Ypos)  // специальный конструктор
            { X = Xpos; Y = Ypos; }
        }
        class PointRef
        {
            public int X;
            public int Y;
            public void Display()
            { Console.WriteLine("X: {0}, Y: {1}", X, Y); }
            public PointRef(int Xpos, int Ypos)  // специальный конструктор
            { 
            X = Xpos;
            Y = Ypos;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=>Assingning value types\n");
            PointRef p1 = new PointRef(10,10);
            PointRef p2 = p1;

            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();

            Console.ReadLine();


        }
      
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1.ValueAndReferenceTypes
{
    
    internal class Program
    {
        class ShapeInfo
        {
            public string InfoString;
            public ShapeInfo(string info)
            {
                InfoString = info;
            }


        }
        // Структура содержит член ссылочного типа
        struct Rectangle
        {
            public ShapeInfo RectInfo;
            public int RectTop, RectLeft, RectBottom, RectRight;
            public Rectangle(string info, int top, int left, int bottom, int right)
            {
                RectInfo = new ShapeInfo(info);
                RectTop = top; RectLeft = left;
                RectBottom = bottom; RectRight = right;
            }
            public void Display()
            { 
                Console.WriteLine("String = {0}, Top {1}, Left {2}, Bottom {3}, Right {4}",
                RectInfo.InfoString, RectTop, RectLeft, RectBottom, RectRight);
            }

        }
        static void Main(string[] args)
        {
            ValueTypeContainingRefType();

            Console.ReadLine();
        }

        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            Console.WriteLine("-> Assingning r2 to r1");
            Rectangle r2 = r1;
            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "Thih is new info!";
            r2.RectBottom = 444;
            r1.Display();
            r2.Display();
        }
    }
}

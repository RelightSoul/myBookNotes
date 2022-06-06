using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****");

            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            Point secondPoint = new Point(20, 20);
            secondPoint.DisplayStats();
            // ситаксис инизиализации объектов
            Point thirdPoint = new Point { X = 30, Y = 30 }; // Point thirdPoint = new Point() {X = 30, Y = 30}; явно
            thirdPoint.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 90 };
            goldPoint.DisplayStats();
            Console.WriteLine();


            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 20, Y = 20 },
            };

            // Традиционная запись
            //Rectangle rect = new Rectangle();
            //Point p1 = new Point();
            //p1.X = 10;
            //p1.Y = 10;
            //rect.TopLeft = p1;
            //Point p2 = new Point();
            //p2.X = 20;
            //p2.Y = 20;
            //rect.BottomRight = p2;
            myRect.DisplayStats();


            Console.ReadLine();
        }
    }
}

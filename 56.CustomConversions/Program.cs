using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.CustomConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with conversions *****\n");
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();

            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Rectangle rect = new Rectangle(10,5);
            DrawSquare((Square)rect);

            int count = 5;
            Square intRect = (Square)count;
            Console.WriteLine(intRect.ToString());
            intRect.Draw();

            Square s3 = new Square { Length = 7};
            Rectangle rect2 = s3;
            Console.WriteLine(rect2);
            Square s4 = new Square() { Length = 5};
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine(rect3);
            Console.ReadLine();
        }
        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}

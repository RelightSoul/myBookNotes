using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.InterfaceHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызвать на уровне объекта.
            Console.WriteLine("***** Simple Interface Hierarchy *****");
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();
            Console.WriteLine();

            // Получить IAdvancedDraw явным образом.
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
            {
                iAdvDraw.DrawUpsideDown();
            }

            Console.ReadLine();
        }
    }
}

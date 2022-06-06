using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.MIInterfaceHierarchy
{
    internal class Square : IShape
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Вывести на экран");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Вывести на принтер");
        }

        int IShape.GetNumberOfSides()
        {
            return 4;
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}

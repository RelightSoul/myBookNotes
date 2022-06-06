using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.InterfaceNameClash
{
    internal class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //возвращаемыйТип ИмяИнтерфейса. ИмяМетода (параметры) {}
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to Memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to Printer...");
        }
    }
}

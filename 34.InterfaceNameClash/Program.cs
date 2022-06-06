using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.InterfaceNameClash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon oct = new Octagon();

            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            ((IDrawToMemory)oct).Draw();  // сокращённая форма

            if (oct is IDrawToPrinter dtm)  //Можно использовать is
                dtm.Draw();

            Console.ReadLine();
        }
    }
}

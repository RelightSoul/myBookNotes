using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            Hexagon hex = new Hexagon("Boon");
            hex.Draw();
            Console.WriteLine();
            Circle cir = new Circle("Omela");
            cir.Draw();
            Console.WriteLine();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Sarra"),
                new Circle("Liza"), new Hexagon("Mars") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();
            ThreeDCircle circ3D = new ThreeDCircle();
            circ3D.Draw();
            // Здесь вызывается метод Draw(), определенный в родительском классе!
            //(Circle) явное приведение
            ((Circle)circ3D).Draw();

            Console.ReadLine();
        }
    }
}

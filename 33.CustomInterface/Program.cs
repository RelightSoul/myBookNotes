using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.CustomInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");

            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);
            Console.WriteLine();

            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (hex2 != null)
            {
                Console.WriteLine(itfPt2.Points);
            }
            else
            {
                Console.WriteLine(" Not pointly...");
            }
            Console.WriteLine();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("Jojo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy ip)
                {
                    Console.WriteLine("-> Points: {0}", ip.Points);                    
                }
                if (myShapes[i] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes[i]);
                }
                //if (myShapes[i] is IDraw3D dr)
                //{
                //    DrawIn3D(dr);
                //}
                else
                {
                    Console.WriteLine("-> {0}'s not pointly! ", myShapes[i].PetName);
                }
            }
            Console.WriteLine();

            IPointy firstPointItemInArray = FindFirstPointlyShape(myShapes);
            Console.WriteLine("The first item is: {0}", firstPointItemInArray?.Points??0);
            Console.WriteLine();

            IPointy[] myPointyObjects = {new Hexagon(), new Knife(),
                new Triangle(), new Fork(), new PitchFork()}; 
            foreach (IPointy point in myPointyObjects)
                Console.WriteLine("Object has: {0}", point.Points);

            Console.ReadLine();
        }


        static void DrawIn3D (IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDra3D compatible type");
            itf3d.Draw3D();
        }
        static IPointy FindFirstPointlyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                {
                    return ip;
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.CustomInterface
{
    abstract internal class Shape
    {   //можно так public string PetName { get; set; } = "NoName";
        public string PetName { get; set; }
        // abstract вынудить все дочерние классы определять способ своей визуализации
        public abstract void Draw();
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}
        //= "NoName" необязательный параметр  = "NoName", если значение не присвоенно
        public Shape(string name = "NoName")
        {
            PetName = name;
        }

    }
    
}

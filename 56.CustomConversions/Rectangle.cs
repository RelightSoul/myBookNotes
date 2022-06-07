using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56.CustomConversions
{
    public struct Rectangle
    {
        //когда в структуре применяется синтаксис автоматических свойств, внутри всех специальных
        //конструкторов должен явно вызываться стандартный конструктор для инициализации закрытых полей
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h) :this() //явное связывание в цепочку со стандартным конструктором
        {
            Width = w;
            Height = h; 
        }
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()=> $"[Width = {Width}; Height = {Height}]";

        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle()
            {
                Height = s.Length,
                Width = s.Length * 2
            };
            return r;
        }
    }
}

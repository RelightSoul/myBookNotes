using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Shapes
{
    class ThreeDCircle : Circle
    {
        // new Скрыть свойство PetName, определенное выше в иерархии,
        public new string PetName { get; set; }
        // new Скрыть любую реализацию Draw(), находящуюся выше в иерархии
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}

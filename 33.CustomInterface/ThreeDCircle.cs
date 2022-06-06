using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.CustomInterface
{
    class ThreeDCircle : Circle, IDraw3D
    {
        // new Скрыть свойство PetName, определенное выше в иерархии,
        public new string PetName { get; set; }
        // new Скрыть любую реализацию Draw(), находящуюся выше в иерархии
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
        public void Draw3D()
        {
            Console.WriteLine("Drawing Cicrle in 3D");
        }

    }
}

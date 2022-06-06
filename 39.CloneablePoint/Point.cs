using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point() { }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point(int x, int y, string name) : this(x, y)
        {
            desc.PetName = name;
        }

        public override string ToString() => $"X = {X}; Y = {Y};" +
            $" Name = {desc.PetName};\nID ={desc.PointID}\n";

        //public object Clone()=> new Point(X, Y);

        // Копировать все поля Point по очереди,
        public object Clone()
        {
            Point newPoint = (Point)MemberwiseClone();
            PointDescription currDesc = new PointDescription();
            currDesc.PetName = this.desc.PetName;
            newPoint.desc = currDesc;
            return newPoint;
            //При наличии класса или структуры, которая содержит т
            //олько типы значений, необходимо реализовать метод Clone
            //() с использованием метода MemberwiseClone (). Однако
            //если есть специальный тип, поддерживающий ссылочные типы,
            //тогда для построения глубокой копии может потребоваться
            //создать новый объект, который учитывает каждую переменную-член
            //ссылочного типа.
        }
    }
}

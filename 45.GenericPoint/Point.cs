using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.GenericPoint
{
    public struct Point<T>
    {
        private T xPos;
        private T yPos;

        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y
        {
            get { return yPos; } 
            set { yPos = value; }
        }
        
        public override string ToString()
        {
            return $"[{xPos}, {yPos}]";
        }
        public void ResetPoint()
        {
            // Ключевое слово default в языке C# перегружено.
            // При использовании с обобщениями оно представляет
            // стандартное значение для параметра типа.
            xPos = default(T);
            yPos = default(T);
        }
    }
}

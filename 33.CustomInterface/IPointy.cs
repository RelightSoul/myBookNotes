using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.CustomInterface
{   // Этот интерфейс определяет поведение наличия вершин
    internal interface IPointy
    {   // Неявно открытый и абстрактный
        //byte GetNumberOfPoints ();
        byte Points { get; }
    }      
}






//    // Ошибка! Интерфейсы не могут иметь поля данных!
//    public int numbOfPoints;
//    // Ошибка! Интерфейсы не могут иметь конструкторы1
//    public IPointy() { numbOfPoints = 0; }
//    // Ошибка! Интерфейсы не могут предоставлять реализацию своих членов'
//    byte GetNumberOfPoints() { return numbOfPoints; }

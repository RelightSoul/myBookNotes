using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65.SimpleGC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** GC Basics *****");
            // Создать новый объект Car в управляемой куче.
            // Возвращается ссылка на этот объект (refToMyCar)           
            Car refToMyCar = new Car("Zippy",50);
            // Операция точки (.) используется для обращения к членам
            // объекта с применением ссылочной переменной
            Console.WriteLine(refToMyCar.ToString());
            Console.WriteLine();

            Console.WriteLine("***** Fun woth System.GC");
            // Вывести оценочное количество байтов, выделенных в куче.
            Console.WriteLine("Estimated bytes o heap {0}", GC.GetTotalMemory(false));
            // Значения MaxGeneration начинаются c 0, поэтому при выводе добавить 1
            Console.WriteLine("This OS has {0} object generations\n",GC.MaxGeneration+1);
            
            Car refToMyCar2 = new Car("Lada", 100);
            Console.WriteLine(refToMyCar2.ToString());
            // Вывести поколение объекта refToMyCar.
            Console.WriteLine(GC.GetGeneration(refToMyCar2));
            // Принудительно запустить сборку мусора
            //и ожидать финализации каждого объекта.
            GC.Collect(0);  // cборка в нулевом поколении
            GC.WaitForPendingFinalizers();
            Console.WriteLine(GC.GetGeneration(refToMyCar2)); //повысил поколение после сборки
            Console.ReadLine();
        }
        static void MakerCar()
        {

            // Если myCar - единственная ссылка на объект Саг, то после
            // завершения этого метода объект Саг *может* быть уничтожен.
            Car car = new Car();

            //• Поколение 0.Идентифицирует новый размещенный в памяти объект, который
            //еще никогда не помечался как подлежащий сборке мусора.
            //• Поколение 1.Идентифицирует объект, который уже пережил одну сборку мусора
            //(т.е.он был помечен как подлежащий сборке мусора, но не удалялся из-за наличия достаточного пространства в куче).
            //• Поколение 2.Идентифицирует объект, которому удалось пережить более одной
            //очистки сборщиком мусора.
        }
        public enum GCColletionMode
        {
            Default,        //Текущим стандартным значением является Forced.
            Forced,         //Указывает исполняющей среде начать сборку немедленно. 
            Optimized       //Позволяет исполняющей среде выяснить,
                            //оптимален ли текущий момент для удаления объектов.
        }
    }
}

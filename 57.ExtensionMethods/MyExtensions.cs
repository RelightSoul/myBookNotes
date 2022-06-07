using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensionMethods

{
    static class MyExtensions
    {
        // Этот метод позволяет объекту любого типа отобразить сборку, в которой он определен.
        public static void DisplayDefiningAssemble(this object obj)
        {
            Console.WriteLine("{0} livers here: => {1}\n", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }
        // Этот метод позволяет любому целочисленному значению изменить порядок
        // следования десятичных цифр на обратный. Например, для 56 возвратится 65.
        public static int ReverseDigits(this int i)
        {
            //делаем из инта строку, а из строки массив символов
            char[] digits = i.ToString().ToCharArray();
            //Меняем порядок значений массива на обратный
            Array.Reverse(digits);
            //Приводим массив символов к строке
            string newDigits = new string(digits);
            //Преобразуем строку в инт 
            return int.Parse(newDigits);            
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.SimpleFinalize
{
    class MyResourceWrapper
    {
        // Очистить неуправляемые ресурсы.
        // Выдать звуковой сигнал при уничтожении
        // (только в целях тестирования).
        ~MyResourceWrapper()=>Console.Beep(); 
    }
}

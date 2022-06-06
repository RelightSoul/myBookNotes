using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.ProcessMultipleExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****");
            Car myCar = new Car("Larisa", 90);

            try
            {
                myCar.Accelerate(-10);
            }
            //блоки catch должны быть структурированы так,
            //чтобы первый catch перехватывал наиболее специфическое исключение            
            catch (CarIsDeadException e)
                when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday) //дополнительное условие
            {
                // Выводится, только если выражение в конструкции when вычисляется как true.
                Console.WriteLine("Catching car is dead!");

                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally    //выполняется всегда
            {
                myCar.CrankTunes(false);
            }

            //try                                         
            //{
            //    myCar.Accelerate(-10);
            //}
            //catch                                         общий оператор catch
            //{
            //    Console.WriteLine("Произошло что-то плохое");
            //}

            //значение передается вверх по цепочке вызовов
            //catch(CarIsDeadException e)
            //{
            //    // Выполнить частичную обработку этой ошибки и передать ответственность,
            //    throw;
            //}

            Console.ReadLine();
        }


    }
}

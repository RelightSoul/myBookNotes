using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNubmer = 50;
            Console.WriteLine();

            PTSalesPerson sam = new PTSalesPerson("Sam", 25, 5436, 10000, "good man", 4);
            sam.GiveBonus(1000);
            Console.WriteLine(sam.Pay);
            sam.DisplayStats();
            Console.WriteLine();
            
            //Manager chucky = new Manager("Chucky",33,55436,120000,"42-4455-4",9000);
            //double cost = chucky.GetBenefitCost();
            //chucky.DisplayStats();
            //Console.WriteLine();
            //Console.WriteLine($"{cost}");
            //Console.WriteLine();          


            Employee.BenefitPackage.BenefitPackageLevel myBenLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.WriteLine(myBenLevel);

            // неявное приведение;
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            Console.WriteLine();
            //явное приведение
            //(класс_к_которому_нугжно_привести)существующая_ссылка
            //GivePromotion((Manager)frank);
            object frank = new Manager();
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            object[] myAray = new object[4];
            myAray[0] = 12323;
            myAray[1] = new Hexagon();
            myAray[2] = new Manager();
            myAray[3] = "Hello bastard";
            foreach (object i in myAray)
            {
                //if (i is var _)      is c отбрасыванием, отбрасывание чего либо.
                //{
                //    // Делать что-то.
                //}
                //если типы не совместимы, тогда ключевое слово is возвращает false,
                Hexagon h = i as Hexagon;  // as проверяет является ли объект, шестиугольником
                if (h == null)
                {
                    Console.WriteLine("This is not a HEXAGON");
                }
                else
                {
                    h.Draw();

                }
            }
            Console.WriteLine();
            GivePromotion(sam);
            Console.WriteLine();
            GivePromotion(fred);
            
            Console.ReadLine();
        }
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
            switch (emp)
            {
                case SalesPerson s when s.SalesNubmer > 5:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNubmer);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;
                case PTSalesPerson _:
                    Console.WriteLine("Игнор");
                    break;
                case null:
                    Console.WriteLine(0);
                    break;
            }
            Console.WriteLine();
        }
    }
}

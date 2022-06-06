using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Vlad",4404,35000);
            emp.GiveBonus(1500);
            emp.DisplayStats();

            emp.Name=("Super mandffffff");
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.ReadLine();
        }
    }
}

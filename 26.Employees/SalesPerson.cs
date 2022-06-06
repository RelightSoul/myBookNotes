using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Employees
{
    internal class SalesPerson : Employee
    {
        public int SalesNubmer { get; set; }

        public SalesPerson(string fullName, int age, int id, float currPay, string ssn, int sales)
            : base (fullName,age,id,currPay,ssn)      
        {
            SalesNubmer = sales;
        }

        public SalesPerson() { }
        // override даёт изменить реализацию деталей
        // sealed запечатывает переопределение метода в подклассе
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNubmer >= 0 && SalesNubmer <= 100)
                salesBonus = 10;
            else
            if (SalesNubmer >= 101 && SalesNubmer <= 200)
                salesBonus = 15;
            else
                salesBonus = 20;
            base.GiveBonus(amount*salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}",SalesNubmer);
        }
    }
}

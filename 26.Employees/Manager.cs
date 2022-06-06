using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Employees
{
    sealed class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int id, float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, id, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }

        public Manager() { }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }


    }
}

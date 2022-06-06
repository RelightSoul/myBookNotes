using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Employees
{
    sealed class PTSalesPerson :SalesPerson
    {
        public PTSalesPerson(string name, int age, int id, float currPay, string ssn, int sales )
            : base( name, age, id, currPay, ssn, sales )
        {

        }

        public override void DisplayStats()
        {
            base.DisplayStats();
        }
    }
}

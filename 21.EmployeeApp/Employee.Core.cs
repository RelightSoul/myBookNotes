using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.EmployeeApp
{
    //частичный класс
    partial class Employee
    {
        // поля данных
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        //конструкторы
        public Employee() { }
        // присваиваем возраст 0, если нет информации о нём
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Employees
{
    //partial частичный класс// abstract запрещает создание нового объекта Employee в программе
    partial class Employee
    {
        //Дочерние классы теперь могут иметь прямой доступ к этой информации.
        protected string empName;
        public int ID { get; set; }
        public float Pay { get; set; }
        public int Age { get; set; }
        protected string empSSN;
        //свойства
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name lenght exceeds 15 charapters!");
                else
                    empName = value;
            }
        }                   
        // Это 'главный' конструктор, выполняющий всю реальную работу
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;            
        }
        //дополнительные конструкторы
        public Employee() {}
        // присваиваем возраст 0, если нет информации о нём
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            empSSN = ssn;
        }

    }
}

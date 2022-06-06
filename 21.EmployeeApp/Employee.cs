using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.EmployeeApp
{
    // данные в частичном классе
    partial class Employee
    {                       
        //Свойства
        public string Name
        {
            get { return empName; }
            set {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name lenght exceeds 15 charapters!");
                else
                    empName = value;
                }
        }
        // int представляет тип данных, инкапсулируемых этим свойством
        // Обратите внимание на отсутствие круглых скобок.
        public int ID 
        { 
            get { return empID; }       //Value внутри set всегда обозначает значение,
            set { empID = value; }      //присваиваемое вызывающим кодом, и всегда имеет тип,                                   
                                        //совпадающий с типом самого свойства
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value;}
        }
        public int Age
        {
            get => empAge;                  // get = {return empAge}; 
            set => empAge = value;          // set = {empAge = value};
        }

        //методы
        public void GiveBonus(float amount) => Pay += amount;
        public void DisplayStats()
        {
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Id : {0}", ID);
            Console.WriteLine("Pay : {0}", Pay);
        }

        //public string GetName()
        //{
        //    return empName;
        //}
        //public void SetName(string name)
        //{
        //    if (name.Length > 15)
        //        Console.WriteLine("Error! Name lenght exceeds 15 charapters!");
        //    else
        //        empName = name;

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.RefTypeValTypeParams
{
    internal class Program
    {
        class Person
        {
            public string personName;
            public int personAge;
            // Конструкторы
            public Person(string name, int age)
            {
                personName = name;
                personAge = age;
            }
            public Person() { }
            public void Display()
            {
                Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
            }
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("***** Passing Person oject by Value *****");
            Person fred = new Person("Fred",12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();

            SendAPersonByReference(ref fred);
            Console.WriteLine("\nAfter by ref call, Person is:");
            fred.Display();

            Console.ReadLine();
        }

        // Если ссылочный тип передается по значению, то вызываемый код может изменять
        // значения данных состояния объекта, но не объект, на который указывает ссылка.
                static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            
            p = new Person("Vlad", 44);
        }

        // Если ссылочный тип передается по ссылке, тогда вызываемый код может изменять
        // значения данных состояния объекта, а также объект, на который указывает ссылка.
        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;

            p = new Person("Nelly", 27);
        }
    }
}

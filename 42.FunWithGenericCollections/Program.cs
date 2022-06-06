using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.FunWithGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UseGenericList();
            //UseGenericStack();
            //UseGenericQueue();
            //UseSortedSet();
            UseDictionary();

            Console.ReadLine();
        }
        private static void UseDictionary()
        {
            Dictionary<string, Person> peopleF = new Dictionary<string, Person>();
            peopleF.Add("Homer", new Person() { FirstName="Homer", LastName="Simson",Age=47});
            peopleF.Add("Marge", new Person("Marge","Simson",45));
            peopleF.Add("Lisa", new Person("Lisa","Simson",9));

            Person lisa = peopleF["Lisa"];
            Console.WriteLine(lisa);

            //// Наполнить с помощью синтаксиса инициализации словаря.
            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person {  FirstName = "Homer", LastName = "Simson", Age = 47 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simson", Age = 45 },
                ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simson", Age = 9 }
            };
        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {   
                new Person { FirstName= "Gomer",LastName="Simson", Age=47},
                new Person { FirstName = "Marge", LastName = "Simson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simson", Age = 8 }
            };
            foreach (Person person in setOfPeople)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            setOfPeople.Add(new Person("Saku", "Jones", 1));
            setOfPeople.Add(new Person() {FirstName="Mikko", LastName="Jones",Age=32});
            foreach (Person person in setOfPeople)
            {
                Console.WriteLine(person);
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }
        static void UseGenericQueue()
        {
            Queue<Person> qPeople = new Queue<Person>();  
            qPeople.Enqueue(new Person {FirstName="Homer",LastName="Simson",Age=47 });
            qPeople.Enqueue(new Person("Marge", "Simson", 45));
            qPeople.Enqueue(new Person("Lisa", "Simson", 9));
            Console.WriteLine("First in line:  {0}",qPeople.Peek().FirstName);
            GetCoffee(qPeople.Dequeue());
            GetCoffee(qPeople.Dequeue());
            GetCoffee(qPeople.Dequeue());
            try
            {
                GetCoffee(qPeople.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Queue empty! {0}", ex.Message);
            }
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName="Gomer",LastName="Simson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName="Marge", LastName="Simson", Age=45});
            stackOfPeople.Push(new Person ("Lisa","Simson",9));
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}",stackOfPeople.Pop());

            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError: {0}", ex.Message);
            }
        }


        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person { FirstName ="Homer", LastName = "Simpson", Age = 47},
                new Person { FirstName ="Marge", LastName = "Simpson", Age = 45},
                new Person { FirstName ="Lise", LastName = "Simpson", Age = 9},
                new Person { FirstName ="Bart", LastName = "Simpson", Age = 8}
            };
            Console.WriteLine("items in list: {0}", people.Count);
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("items in list: {0}", people.Count);
            Person[] arrayOfPeople= people.ToArray();
            foreach (Person person in arrayOfPeople)
            {
                Console.WriteLine("First names: {0}",person.FirstName);
            }            
        }
    }
    
}

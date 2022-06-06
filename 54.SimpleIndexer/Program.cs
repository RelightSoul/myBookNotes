using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.SimpleIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonCollectionArray myPeople = new PersonCollectionArray();

            myPeople[0] = new Person("Homer", "Simson", 40);
            myPeople[1] = new Person("Marge", "Simson", 38);
            myPeople[2] = new Person("Lisa", "Simson", 9);
            myPeople[3] = new Person("Bart", "Simson", 7);
            myPeople[4] = new Person("Maggie", "Simson", 2);

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }

            Console.WriteLine("***************");
            List<Person> myList = new List<Person>();
            myList.Add(new Person("Homer", "Simson", 40));
            myList.Add(new Person("Marge", "Simson", 38));
            myList.Add(new Person("Lisa", "Simson", 9));
            myList.Add(new Person("Bart", "Simson", 7));
            myList.Add(new Person("Maggie", "Simson", 2));

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("Person: {0}", i);
                Console.WriteLine("Name: {0} {1}", myList[i].FirstName, myList[i].LastName);
                Console.WriteLine("Age: {0}", myList[i].Age);
                Console.WriteLine();
            }
            Console.WriteLine("***************");

            PersonCollectionDict myPeopleDict = new PersonCollectionDict();
            myPeopleDict["Homer"] = new Person("Homer", "Simson", 40);
            myPeopleDict["Marge"] = new Person("Marge", "Simson", 38);
            myPeopleDict["Lisa"] = new Person("Lisa", "Simson", 9);
            myPeopleDict["Bart"] = new Person("Bart", "Simson", 7);
            myPeopleDict["Maggie"] = new Person("Maggie", "Simson", 2);
            foreach (Person i in myPeople)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("***************");

            MultiIndexerWithDataTable();

            Console.ReadLine();
        }
        static void MultiIndexerWithDataTable()
        {
            DataTable myTable = new DataTable();
            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));
            myTable.Rows.Add("Mel", "Applebt", 60);
            Console.WriteLine("First Name: {0}", myTable.Rows[0][0]);
            Console.WriteLine("Last Name: {0}", myTable.Rows[0][1]);
            Console.WriteLine("Age: {0}", myTable.Rows[0][2]);
        }
    }
    
}

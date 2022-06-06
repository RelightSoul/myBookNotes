using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _43.FunWithObservableCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
            new Person(){FirstName="Peter",LastName="Murphy" ,Age = 52},
            new Person("Kevin","Key",48),
            };
            people.CollectionChanged += people_CollectionChanged;

            people.Add(new Person("Fred","Smith",32));
            Console.WriteLine();

            people.Remove(new Person() { FirstName = "Kevin", LastName= "Key", Age= 48 });

            Console.ReadLine();
        }

        static void people_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e) 
        {
            Console.WriteLine("Action for this event: {0}",e.Action);

            if (e.Action == 
                System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the old items");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            if (e.Action ==
                System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are new items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }

        public enum NotifyCollectionChangedAction
        {
            Add = 0,
            Remove = 1,
            Replace = 2,
            Move = 3,
            Reset = 4,
        }
    }
}

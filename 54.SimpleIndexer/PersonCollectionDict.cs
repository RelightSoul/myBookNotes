using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.SimpleIndexer
{
    public class PersonCollectionDict : IEnumerable
    {
        private IDictionary<string, Person> listPeople = new Dictionary<string,Person>();
        
        // Специальный индексатор для этого класса
        public Person this[string name]
        {
            get
            {
                return (Person)listPeople[name];
            }
            set
            {
                listPeople[name] = value;
            }
        }

        public void ClearPeople()
        { listPeople.Clear(); } 

        public int Count => listPeople.Count;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();   
        }
    }
}

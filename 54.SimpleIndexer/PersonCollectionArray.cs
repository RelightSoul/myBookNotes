using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.SimpleIndexer
{
    public class PersonCollectionArray : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        // Специальный индексатор для этого класса
        public Person this[int index]
        {
            get
            {
                return (Person)arPeople[index];
            }
            set
            {
                arPeople.Insert(index, value);
            }
        }

        public Person GetPerson (int pos) => (Person)arPeople[pos];

        public void AddPerson(Person p)
        { arPeople.Add(p); }   
        
        public void ClearPeople()
        { arPeople.Clear(); } 

        public int Count => arPeople.Count;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arPeople.GetEnumerator();   
        }
    }
}

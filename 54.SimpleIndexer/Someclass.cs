using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.SimpleIndexer
{
    public class Someclass : IStringContainer
    {
        private List<string> myStr = new List<string>();
        
        public string this[int index] 
        { 
            get => myStr[index]; 
            set => myStr[index].Insert(index,value);
        }
    }
}

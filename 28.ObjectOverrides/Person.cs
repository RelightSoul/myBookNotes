using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.ObjectOverrides
{
    partial class Person
    {
        public override string ToString()
        {
            base.ToString();
            return $"[Firest name: {FirstName}; Last name: {LastName}; Age: {Age}]";
        }

        public override bool Equals(object obj)
        {
            return obj?.ToString() == ToString();
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj is Person && obj !=null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if (temp.FirstName == this.LastName && temp.LastName == this.LastName
        //            && temp.Age == this.Age)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
            
        //    return false;
        //}
        
    }   
}

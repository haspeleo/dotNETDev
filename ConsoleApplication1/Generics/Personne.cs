using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Personne : IComparable<Personne>
    {


        public int Age;
        public string Name;

        //private int Age;
        //private string Name;

        //public int age { 
        //    get 
        //    {
        //        return Age; 
        //    } 
        //}
        //public string name {
        //    get 
        //    {
        //        return Name; 
        //    }
        //}



        public Personne(string name, int age) {
            Name = name;
            Age = age; 
        }

        public Personne()
        {
            // TODO: Complete member initialization
        }


        public int CompareTo(Personne other)
        {
            return Age.CompareTo(other.Age); 

        }
    }
}

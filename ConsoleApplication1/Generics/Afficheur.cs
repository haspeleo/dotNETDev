using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public static class Afficheur
    {

        public static void afficher( object o) {

            Console.WriteLine("Afficheur d'objets: ");
            Console.WriteLine("\t Type: " + o.GetType());
            Console.WriteLine("\t Representation: " + o.ToString());
        
        }

        public static void afficher<T>(T a) { 
        
            Console.WriteLine("Afficheur d'objets: ");
            Console.WriteLine("\t Type: " + a.GetType());
            Console.WriteLine("\t Representation: " + a.ToString());
            
        }


    }
}

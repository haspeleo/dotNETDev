using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public static class Encodage //must be static 
    {
        public static string crypte(this string chaine) {
            return Convert.ToBase64String(Encoding.Default.GetBytes(chaine)); 
        }

        public static string decrypte(this string chaine) { //this in front of string to create extension method
            return Encoding.Default.GetString(Convert.FromBase64String(chaine));
        }
    }
}

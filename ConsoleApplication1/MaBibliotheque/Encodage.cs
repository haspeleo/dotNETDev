using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaBibliotheque
{
    internal static class Encodage //must be static 
    {
        internal static string crypte(this string chaine) {
            return Convert.ToBase64String(Encoding.Default.GetBytes(chaine)); 
        }

        internal static string decrypte(this string chaine) { //this in front of string to create extension method
            return Encoding.Default.GetString(Convert.FromBase64String(chaine));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaBibliotheque
{
    public static class Generateur
    {
        public static string ObtenirIdentifiantUnique() {

            Random random = new Random();
            string chaine = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                chaine += random.Next(0, 100); 
            }

            return chaine.crypte(); 
        }
    }
}

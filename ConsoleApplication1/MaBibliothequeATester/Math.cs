
/*
 * Bibliothèque mathématique à tester 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliothequeATester
{
    public static class Math
    {
        public static int Factorielle(int a) {

            if (a <=1)
            {
                return 1; 
            }
            else
            {
                return a * Factorielle( a - 1);
            }
        }
    }
}

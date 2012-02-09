using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public class TrieurDeTableau
    {
        private delegate void delegateTri(int[] tableau);

        private void trierEtAfficher(int[] tableau, Action<int[]> methodeDeTri) {

            methodeDeTri(tableau);
            foreach (int i in tableau)
            {
                Console.Write(" - " + i);
            }
        
        }

        private void triAscendant(int[] tableau) {

            Array.Sort(tableau);
        }

        private void triDescendant(int[] tableau) {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }

        public void demoTri(int[] tableau) {

            Console.WriteLine("\n--> tri Ascendant ");

            
            //trierEtAfficher(tableau, delegate(int [] tab) {
            //    triAscendant(tab);
            //});
            //ecriture condensée des 3 lignes précédentes
            trierEtAfficher(tableau, tab => triAscendant(tab));

            Console.WriteLine("\n--> tri Descendant ");

            trierEtAfficher(tableau, delegate(int[] tab) { //delegate to an anonymous method
                triDescendant(tab);
            }); 
        }
    }
}

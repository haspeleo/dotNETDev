using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public class TrieurDeTableau
    {
        private delegate void delegateTri(int[] tableau);

        private void triAscendant(int[] tableau) {

            Array.Sort(tableau);
        }

        private void triDescendant(int[] tableau) {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }
    }
}

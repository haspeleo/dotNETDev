using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class MaListeGenerique<T>
    {
        public readonly int MAX = 10; 
        private int capacite;
        private int nbElements;
        T[] tableau; 

        public MaListeGenerique() {

            capacite = MAX; 
            nbElements = 0;
            tableau = new T[capacite]; 
        }

        public void ajouter(T element) {

            if (nbElements >= capacite)
            {
                capacite *= 2;
                T[] tableauPlusGrand = new T[capacite];
                for (int i = 0; i < tableau.Length; i++)
                {
                    tableauPlusGrand[i] = tableau[i];  
                }
                tableau = tableauPlusGrand; 
            }
            tableau[nbElements] = element;
            nbElements++; 
        }

        public T obtenirElement(int indice) {

            if (indice < 0 || indice >= nbElements)
            {
                Console.WriteLine("out of bounds index !!");
                return default(T); 
            }

            return tableau[indice]; 
        }



    }
}

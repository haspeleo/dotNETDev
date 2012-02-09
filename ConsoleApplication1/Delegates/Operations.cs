using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public class Operations
    {
        public void demoOperations() {

            double division = calcul(delegate(int a, int b) {

                return (double)a / (double)b;
            }, 4, 5);

            double puissance = calcul(delegate(int a, int b) {

                return Math.Pow((double)a, (double)b);
            }, 4, 5);

            double somme = calcul((a,b) => a + b, 4, 5); 

            Console.WriteLine("Somme : " + somme);
            Console.WriteLine("Division : " + division);
            Console.WriteLine("Puissance : " + puissance);
        }


        private double calcul(Func<int, int, double> methodeDeCalcul, int a, int b) {

            return methodeDeCalcul(a, b); 
        }

    }
}

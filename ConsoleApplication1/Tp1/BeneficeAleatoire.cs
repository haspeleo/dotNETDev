using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire {

    class BeneficeAleatoire : ICalculateurBenefice
    {
        private double taux; 
        public double Taux
        {
            get
            {
                return taux; 
            }
            set { }
        }

        public BeneficeAleatoire() {

            taux = new Random().Next(0, 1);
            Console.WriteLine("Taux random: "+ Taux);
        }

        public decimal calculeBenefice(decimal solde)
        {
            return (decimal)(1 + Taux) * solde; 
        }
    }
}

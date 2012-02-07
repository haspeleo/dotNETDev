using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire
{
    class BeneficeATauxFixe : ICalculateurBenefice
    {


        private double taux;
        private double p;


        public BeneficeATauxFixe(double tauxFixe) {

            taux = tauxFixe; 
        }
        public double Taux
        {
            get
            {
                return taux; 
            }
            set
            { 
            
            }

        }

        public decimal calculeBenefice(decimal solde)
        {
            return solde * (decimal)(1 + taux); 
        }

    }
}

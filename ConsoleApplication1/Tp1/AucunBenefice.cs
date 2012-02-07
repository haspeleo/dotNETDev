using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire 
{
    class AucunBenefice : ICalculateurBenefice
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

       

        public decimal calculeBenefice(decimal solde)
        {
            return 1 * solde; 
        }
    }
}

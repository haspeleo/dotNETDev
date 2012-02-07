using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire
{
    public class CompteCourant : Compte {

        decimal DecouvertAutorise;
        private ICalculateurBenefice calculateurDeBenefice; 

        public CompteCourant(decimal decouvert, ICalculateurBenefice calculateur) {
            
            DecouvertAutorise = decouvert;
            calculateurDeBenefice = calculateur; 
        }


        public override decimal Solde
        {
            get
            {
                decimal solde = base.Solde;
                return solde + calculateurDeBenefice.calculeBenefice(solde); 
            }
        }

        public override void resumeCompte()
        {
            base.resumeCompte();
            Console.WriteLine("Decouvert Autorise : " + DecouvertAutorise);
            Console.WriteLine("\t Taux: " + calculateurDeBenefice.Taux);
        }
        






    }
}

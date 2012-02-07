using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire
{
    public class CompteEpargneEntreprise : Compte
    {
        decimal tauxAbondement;
        private ICalculateurBenefice calculateurDeBenefice; 


        public override decimal Solde
        {
            get
            {
                decimal solde = base.Solde; 
                return base.Solde * (1 + tauxAbondement) + calculateurDeBenefice.calculeBenefice(solde);
            }
        }

        public CompteEpargneEntreprise (decimal taux, ICalculateurBenefice calculateur) {

            tauxAbondement = taux;
            calculateurDeBenefice = calculateur; 
        }
        
        public override void resumeCompte()
        {
            base.resumeCompte(); 
            Console.WriteLine("Taux Adondement: " + tauxAbondement);
            Console.WriteLine("\t Taux: "+ calculateurDeBenefice.Taux);
        }


    }
}

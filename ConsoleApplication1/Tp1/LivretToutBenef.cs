using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire
{
    class LivretToutBenef : Compte
    {

        private ICalculateurBenefice calculateurDeBenefice;

        public LivretToutBenef(ICalculateurBenefice calculateur) {

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


        public override void resumeCompte() {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("Livret tout Benef de " + Proprietaire); 
            Console.WriteLine("\t Solde " + Solde);
            Console.WriteLine("\t Taux " + calculateurDeBenefice.Taux);
            afficherOperations(); 
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        }




    }
}

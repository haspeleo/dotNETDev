using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine(DateTime.Now);
            Console.Beep(); 

            decimal taux = 5;
            ICalculateurBenefice aucunBenefice = new AucunBenefice(); 
            CompteCourant nicolas = new CompteCourant(taux, aucunBenefice) { Proprietaire = "Nicolas"};
            nicolas.Crediter(200);
            nicolas.Crediter(300);
            nicolas.Debiter(120); 
            nicolas.resumeCompte();

            decimal tauxAbd = 12;
            ICalculateurBenefice beneficeVariable = new BeneficeAleatoire(); 
            CompteEpargneEntreprise ibm = new CompteEpargneEntreprise(tauxAbd, beneficeVariable) { Proprietaire = "IBM"};
            ibm.Crediter(222000); 
            ibm.Crediter(7767600); 
            ibm.Crediter(9980000);
            ibm.Debiter(23830);
            ibm.resumeCompte();

            ICalculateurBenefice beneficeEntreprise = new BeneficeATauxFixe(0.575); 
            LivretToutBenef livret = new LivretToutBenef(beneficeEntreprise) { Proprietaire = "Hassen"};
            livret.Crediter(800);
            livret.Crediter(200);
            livret.resumeCompte(); 

            Console.WriteLine("\n Press Any key to quit !");
            Console.ReadKey();

        }



    }//class
}//namespace

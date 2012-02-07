using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire {

 public abstract class Compte {

     List<OperationsBancaire> listeOperations;
     public string Proprietaire { get; set; }
    
     // update the Solde from the list of operations done to the account
     public virtual decimal Solde
     {
         get
         {
             decimal total = 0;
             foreach (OperationsBancaire operation in listeOperations)
             {
                 if (operation.TypeMouvement == Mouvement.CREDIT)
                     total += operation.Montant;
                 else
                     total -= operation.Montant;
             }
         return total; 
         }
     }

     public Compte() {
         
         listeOperations = new List<OperationsBancaire>(); 
     }


        public virtual void Crediter(decimal somme) {

            OperationsBancaire operation = new OperationsBancaire { Montant = somme, TypeMouvement = Mouvement.CREDIT};
            listeOperations.Add(operation); 
        }

        public virtual void Crediter(decimal somme, Compte compte) {
            Crediter(somme);
            compte.Debiter(somme);
        }

        public virtual void Debiter(decimal somme) { 
            
            OperationsBancaire operation = new OperationsBancaire { Montant = somme, TypeMouvement = Mouvement.DEBIT };
            listeOperations.Add(operation); 
        }

        public virtual void Debiter(decimal somme, Compte compte) {

            Debiter(somme);
            compte.Crediter(somme);
        }

        public virtual void resumeCompte() {
            Console.WriteLine("========================================================================");
            Console.WriteLine("Proprietaire: " + this.Proprietaire);
            Console.WriteLine("\t Solde: " + this.Solde);
            afficherOperations();
        }



        protected void afficherOperations()
        {

            foreach (OperationsBancaire operation in listeOperations)
            {
                if (operation.TypeMouvement == Mouvement.CREDIT)
                {
                    Console.WriteLine("\t +" + operation.Montant);
                }
                else
                {
                    Console.WriteLine("\t -" + operation.Montant);
                }
            }
        }



    }//class
}//namespace

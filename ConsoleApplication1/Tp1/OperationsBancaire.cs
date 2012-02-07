using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire
{

    enum Mouvement
    {
        CREDIT,
        DEBIT
    }

    class OperationsBancaire
    {
        public decimal Montant;
        public Mouvement TypeMouvement; 
       
        public void listerOperations(List<OperationsBancaire> log) {
            foreach (var item in log)
	        {
                Console.WriteLine(item);
	        }
        }
    }
}

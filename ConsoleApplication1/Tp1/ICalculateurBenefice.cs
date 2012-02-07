using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBancaire {

    public interface ICalculateurBenefice 
    {

        double Taux { get; set; }
        decimal calculeBenefice(decimal solde); 


    }
}

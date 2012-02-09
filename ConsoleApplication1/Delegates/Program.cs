using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{


    ////public class Voiture
    ////{
    ////    public delegate void delegateChangementDePrix(decimal nouveauPrix);

    ////    public event delegateChangementDePrix changementDePrix;

    ////    public decimal Prix;

    ////    public void promoSurLePrix()
    ////    {

    ////        Prix = Prix / 2;
    ////        if (changementDePrix != null)
    ////        {
    ////            changementDePrix(Prix);
    ////        }
    ////    }
    ////}


    public class Voiture
    {
        public delegate void DelegateDeChangementDePrix(decimal nouveauPrix);
        public event DelegateDeChangementDePrix ChangementDePrix;
        public decimal Prix { get; set; }

        public void PromoSurLePrix()
        {
            Prix = Prix / 2;
            if (ChangementDePrix != null)
                ChangementDePrix(Prix);
        }
    }


    public class DemoEvenement
    {
    
        public void Demo()
    {
        Voiture voiture = new Voiture { Prix = 10000 };

        Voiture.DelegateDeChangementDePrix delegateChangementDePrix = voiture_ChangementDePrix;
        voiture.ChangementDePrix += delegateChangementDePrix;

        voiture.PromoSurLePrix();
    }

    private void voiture_ChangementDePrix(decimal nouveauPrix)
    {
        Console.WriteLine("Le nouveau prix est de : " + nouveauPrix);
    }
}

    //public class DemoEvenement
    //{
    //    public void Demo()
    //    {
    //        Voiture voiture = new Voiture { Prix = 10000 };

    //        Voiture.DelegateDeChangementDePrix delegateChangementDePrix = voiture_ChangementDePrix;
    //        voiture.ChangementDePrix += delegateChangementDePrix;

    //        voiture.PromoSurLePrix();
    //    }

    //    private void voiture_ChangementDePrix(decimal nouveauPrix)
    //    {
    //        Console.WriteLine("Le nouveau prix est de : " + nouveauPrix);
    //    }
    //}

        //public class DemoEvenement { 

        //    public void demo() {
        //        Voiture voiture = new Voiture { Prix = 10000};
        //        voiture.delegateChangementDePrix promoPrix = changerDePrix;
        //        voiture.changementDePrix += delegateChangementDePrix;
        //    }

        //    private void changerDePrix(decimal nouveauPrix) {
        //        Console.WriteLine("Nouveau Prix : " + nouveauPrix);
        //    }
        //}



    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.Beep();
            Console.WriteLine("\n delegates =================================================");

            int[] tableau = new int[] { 12, 1, 8, 4, 6, 9, 10};
            new TrieurDeTableau().demoTri(tableau);


            Console.WriteLine("\n delegates Action and Func and lambdas expressions==========");
            new Operations().demoOperations();

            Console.WriteLine("\n events ====================================================");
            new DemoEvenement().Demo();




            Console.WriteLine("\nPress a key to exit ...");
            Console.ReadKey(); 
        }
    }
}

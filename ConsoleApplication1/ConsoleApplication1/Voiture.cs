using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public partial class Voiture : IComparable
    {

        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

    }

    public partial class Voiture : IComparable {


        public Voiture()
        {
            Couleur = "Rouge";
        }

        public Voiture(string couleur)
        {
            Couleur = couleur;
        }

        public override bool Equals(object obj)
        {
            Voiture v = obj as Voiture; //verifier qu'on a bien une voiture
            if (v == null)
                return false;
            else
                return Vitesse == v.Vitesse && Couleur == v.Couleur && Marque == v.Marque;
        }

        public override int GetHashCode()
        {
            return Couleur.GetHashCode() * Marque.GetHashCode() * Vitesse.GetHashCode();
        }




        public int CompareTo(object obj)
        {
            Voiture voiture = obj as Voiture;
            //forme abrégée
            //return Vitesse.CompareTo(voiture.Vitesse); 
            
            if (this.Vitesse < voiture.Vitesse)
            {
                return -1;
            }
            if (this.Vitesse > voiture.Vitesse)
            {
                return 1; 
            }
            else
            {
                return 0; 
            }
        }






    }
}

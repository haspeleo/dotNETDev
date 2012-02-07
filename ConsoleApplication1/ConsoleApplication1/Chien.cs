using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Chien : Animal
    {

        public Chien() : base() { }
        public Chien(string prenomChien) : base(prenomChien) { }

        public void aboyer()
        {
            Console.WriteLine("Waouf !!");
        }
        public void vieillir()
        {
            age++;
        }
        public void naissance()
        {
            age = 0;
            estVivant = true;
        }

        //implementer la classe abstraite Animal 
        public override void seDeplacer()
        {
            Console.WriteLine("Chien: Je me deplace sur 4 pattes"); 
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Animal
    {

        public int nombreDePattes { get; set; }
        protected bool estVivant;
        public int age;
        protected string prenom;
        private Coeur coeur; 

        
        public Animal()
        {
            prenom = "sans prenom";
            coeur = new Coeur(); 
        }
        
        public Animal(string prenomAnimal)
        {
            prenom = prenomAnimal;
        }
        
        public void respirer()
        {
            Console.WriteLine("Je suis: " + prenom + ", je respire");
        }

        public abstract void seDeplacer();

        public void mourir() {
            coeur.stop(); 
        }
    }
}

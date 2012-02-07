using System;
using System.Collections;
using System.Collections.Generic; 
using System.Numerics; 
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    enum Weather
    {
        SUNNY = 1,
        CLOODY = 2,
        FOGGY = 3,
        WINDY = 4
    }

    class Program
    {

        public static void testSyntax()
        {

            int age = 27;
            string prenom = "Mon prenom est \"Hassen\"\n";
            string ville = "Massy";
            string codePostal = "91300";

            Console.WriteLine(prenom);
            Console.WriteLine(age);
            Console.WriteLine("Habite à : " + codePostal + " - " + ville);
            Console.WriteLine("TODO list");
            Console.WriteLine("\t - Learn Flex");
            Console.WriteLine("\t -Integration with .NET");
            string file = @"C:\Projects\Program.cs";
            Console.WriteLine(file);
        }

        public static void conditionnals()
        {

            decimal compteBancaire = 300;
            if (compteBancaire > 0)
            {
                Console.WriteLine("Votre compte est Créditeur");
            }
            else
            {
                Console.WriteLine("Votre compte est Débiteur");
            }

            string civilite = "M.";
            switch (civilite)
            {
                case "M.":
                    Console.WriteLine("Bonjour Mr");
                    break;
                case "Mlle.":
                    Console.WriteLine("Bonjour Mademoiselle");
                    break;
                case "Mme":
                    Console.WriteLine("Bonjour Madame");
                    break;
                default:
                    Console.WriteLine("Bonjour inconnu");
                    break;

            }
        }

        public static void printArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void printList(ArrayList list)
        {

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void complexNumber(Complex c)
        {
            Console.WriteLine(c);
            Console.WriteLine("[Partie réelle = " + c.Real + " ; Partie Immaginaire = " + c.Imaginary + "]");
        }

        public static void tryToCast(string word)
        {
            int age;
            if (int.TryParse(word, out age))
            {
                Console.WriteLine("Possible conversion, age = ", +age);
            }
            else
            {
                Console.WriteLine("Impossible conversion");
            }
        }


        public static void askToQuit(ConsoleKeyInfo pressedKey)
        {

            do
            {
                ConsoleKeyInfo key = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.N:
                        Console.WriteLine("Continuing the program ...");
                        break;
                    case ConsoleKey.O:
                        Console.WriteLine("Quitting the program ...");
                        break;
                    default:
                        Console.WriteLine("Correct your choice by pressing O or N !");
                        break;
                }

            } while (pressedKey.Key != ConsoleKey.O || pressedKey.Key != ConsoleKey.N);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Parallels");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(DateTime.Now);
            foreach (string parameters in args)
            {
                Console.WriteLine(parameters);
            }
            Console.WriteLine(Environment.UserName);

            Console.Beep();
            testSyntax();
            conditionnals();
            string[] array = new string[] {"Lundi", "Mardi", "Mercredi", 
				"Jeudi", "Vendredi", "Samedi", "Dimanche"};
            printArray(array);
            Console.WriteLine("Sorting array elements \n");
            Array.Sort(array);
            printArray(array);
            ArrayList liste = new ArrayList();
            liste.Add(8);
            liste.Add(12);
            liste.Add(11);
            liste.RemoveAt(1);
            printList(liste);

            Console.WriteLine(Weather.SUNNY);
            Complex c = Complex.One;
            complexNumber(c);
            Console.WriteLine(Convert.ToInt32("123"));
            tryToCast("AAV27KN");
            Console.WriteLine("You want to Quit the Program (O/N) ?");

            Voiture voiture = new Voiture("verte") { Couleur = "Bleue" };
            Console.WriteLine(voiture.Couleur);
            Console.WriteLine("----------------Heritage---------------------------------");

            ArrayList animaux = new ArrayList();
            animaux.Add(new Chien());
            animaux.Add(new Chien("Milou"));
            animaux.Add(new Chien("Dingo"));
            animaux.Add(new Chat("Idéfix"));
            animaux.Add(new Chat("Tom"));
            animaux.Add(new Chat());

            foreach (Animal item in animaux)
            {
                item.respirer();
            }

            Voiture bmw = new Voiture { Vitesse = 220, Marque = "BMW", Couleur = "Grise" };
            Voiture mercedes = new Voiture { Vitesse = 340, Marque = "Mercedes", Couleur = "Noire" };

            if (bmw.Equals(mercedes))
            {

                Console.WriteLine("Les objets référencent la meme chose");
            }
            else
            {
                Console.WriteLine("Les objets NE référencent PAS la meme chose");
            }

            Console.WriteLine(" ----- Sorting an array of cars based on IComparable capability ----- ");
            Voiture[] cars = new Voiture[] { new Voiture {Vitesse = 120}, new Voiture {Vitesse = 180}, new Voiture{Vitesse = 230}};
            Array.Sort(cars);
            foreach (Voiture item in cars)
            {
                Console.WriteLine(item.Vitesse);
            }
            Avion A380 = new Avion() { NombrePropulseurs = 4};
            Oiseau aigle = new Oiseau() { NombrePropulseurs = 2};
            List<IVolant> volants = new List<IVolant> { A380, aigle}; 
            

            foreach (var item in volants)
            {
                item.Voler(); 
            }
            A380.Rouler();

            Console.WriteLine("--------------- Abstract classes ---------------");

            foreach (Animal item in animaux)
            {
                item.seDeplacer(); 
            }
            //NumberGame nb = new NumberGame(); 
            //nb.guessNumber(); 

            Console.WriteLine("Press any key quit !");
            Console.ReadKey(); 



        }
    }
}

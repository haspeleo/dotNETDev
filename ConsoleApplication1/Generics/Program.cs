

/*
 * http://www.zeusedit.com/zforum/viewtopic.php?t=1235
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaBibliotheque;
using System.Configuration;

namespace Generics 
{
    class Program
    {

        public static void swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp; 
        }

        public static U creer<U>() where U : IVolant, new() {

            U u = new U();
            u.deplierAiles();
            u.voler();
            u.atterir();
            return u; 
        }

        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine(" --- Queue manipulation --- "); 
            Queue<int> file = new Queue<int>();
            file.Enqueue(12);
            file.Enqueue(10);
            int top = file.Dequeue();
            Console.WriteLine("head of the queue: " + top);
            
            Console.WriteLine(" --- LinkedList manipulation --- ");
            LinkedList<string> mountains = new LinkedList<string>();
            mountains.AddFirst("Everest");
            mountains.AddLast("K2");
            mountains.AddLast("Kilimanjaro");
            mountains.AddLast("McKinley");

            foreach (string mt in mountains)
            {
                Console.WriteLine(mt); 
            }

            Console.WriteLine("\n--- Dictionary manipulation --- ");
            Dictionary<string, Personne> annuaire = new Dictionary<string, Personne>();
            Personne marine = new Personne { Name = "Marine", Age = 21 };
            Personne natasha = new Personne { Name = "Natasha", Age = 26 }; 
            annuaire.Add("06 800 900", marine);
            annuaire.Add("06 800 700", natasha);
            string key = "06 800 900";
            Console.WriteLine("Search for Entry with key : " + key);
            Console.WriteLine("Nom :  " +annuaire[key].Name);
            Console.WriteLine("Age :  " +annuaire[key].Age);

            Console.WriteLine("\n--- Affichage des types --- ");
            int i = 10;
            string str = "ABCD";

            Afficheur.afficher(i);
            Afficheur.afficher(str);
            Afficheur.afficher(annuaire);
            Console.WriteLine("\n--- Affichage *Générique* des types --- ");
            Afficheur.afficher<int>(i);
            Afficheur.afficher<string>(str);
            Afficheur.afficher<Dictionary<string, Personne>>(annuaire);

            Console.WriteLine("Generic swap function");
            swap<Personne>(ref marine, ref natasha);
            swap<Personne>(ref marine, ref natasha);
            Console.WriteLine(marine.Name);
            Console.WriteLine(natasha.Name);

            Console.WriteLine("--- Liste personalisée --- ");
            MaListeGenerique<Personne> listeDePersonnes = new MaListeGenerique<Personne>();
            listeDePersonnes.ajouter(marine);
            listeDePersonnes.ajouter(natasha);
            Console.WriteLine(listeDePersonnes.obtenirElement(0).Name);
            Console.WriteLine(listeDePersonnes.obtenirElement(1).Name);
            //Console.WriteLine(listeDePersonnes.obtenirElement(2).Name);
            Console.WriteLine("\n --- Generics and interface ---");
            int resultatComparaison = marine.CompareTo(natasha);
            if (resultatComparaison == 1)
            {
                Console.WriteLine("Natasha est plus jeune que Marine");
            }

            else
	        {
                Console.WriteLine("Marine est plus jeune que Natasha");
	         }



            Console.WriteLine(" *** Restrictions sur les types génériques *** ");
            Oiseau aigle = creer<Oiseau>();
            aigle.Espece = "rapace";
            Avion A380 = creer<Avion>(); 
            A380.Modele = "Jumbo jet";
            
            Console.WriteLine("\n  *** Methodes d'externsions *** ");
            string codeSecret = "ENIGMA";
            string codeCrypte = Encodage.crypte(codeSecret);
            Console.WriteLine(codeCrypte);
            string codeDecrypte = Encodage.decrypte(codeCrypte);
            Console.WriteLine(codeDecrypte);

            Console.WriteLine("================ Using MaBibliotheque ===================");

            Client client = new Client("Chloe", "5566");
            Console.WriteLine(client.MotDePasse);
            Console.WriteLine(Generateur.ObtenirIdentifiantUnique());
            double a = 10; 
            double b = 3;
            double c = a / b; 
            Console.WriteLine("================ Indice des parametres ==================");
            Console.WriteLine("Liste des parametres : {0} {1} {2}", a, b, c.ToString("000.###"));
            Console.WriteLine("\n**** Reading in the XML configuration file App.config ***");
            foreach (string cle in ConfigurationManager.AppSettings)
            {
                Console.WriteLine("< Key: " + cle + ", Value: " + ConfigurationManager.AppSettings[cle] + ">");
            }


            Console.ReadKey();
        }



    }//class
}//namespace

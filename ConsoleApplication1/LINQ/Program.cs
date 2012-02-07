/*
 * http://code.msdn.microsoft.com/windowsdesktop/101-LINQ-Samples-3fb9811b --101 Linq examples
 * **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args) {

           Console.WriteLine(DateTime.Now);
           Console.Beep();

           Console.WriteLine("------------------LINQ Language INtegrated Query----------------------");
           List<int> liste = new List<int>{2, 6, 1, 21, 33, 10, 15, 81, 71 };
           IEnumerable<int> requete = from i in liste
                                      where i > 5
                                      select i;

           foreach (int i in requete)
           {
               Console.WriteLine(i);
           }

           List<Client> listeClient = new List<Client> { 
            new Client { Identifiant = 1, Nom = "Marine", Age = 21},
            new Client { Identifiant = 2, Nom = "Chloe", Age = 22}, 
            new Client { Identifiant = 3, Nom = "Ophelie", Age = 28}
           };

           IEnumerable<string> request = from client in listeClient
                                         where client.Age > 21
                                         orderby client.Age, client.Nom
                                         select client.Nom;

           foreach (string item in request)
           {
               Console.WriteLine(item);
           }
           var request2 = from client in listeClient
                          where client.Age > 21
                          orderby client.Age, client.Nom
                          select new { client.Nom, client.Age};

           foreach (var obj in request2)
           {
               Console.WriteLine("{0} has {1} years", obj.Nom, obj.Age);
           }
           Console.WriteLine("\nNombre des clients");
           int nbClient = listeClient.Count;
           Console.WriteLine(nbClient);
           Console.WriteLine("\nMoyenne des ages des clients");

           Console.WriteLine("Press a key ...");
           Console.ReadKey(); 

        }
    }
}

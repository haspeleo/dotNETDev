using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Avion : IVolant
    {
        public string Modele; 

        public void deplierAiles() {
            Console.WriteLine("Avion: Je deplie mes ailes mécaniques"); 
        }

        public void voler() {
            Console.WriteLine("Avion: Je vole grace aux moteurs ");
        }
    }

}

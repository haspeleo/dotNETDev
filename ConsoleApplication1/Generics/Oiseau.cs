using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Oiseau : IVolant
    {
        public string Espece; 
        public void deplierAiles()
        {
            Console.WriteLine("Oiseau: Je déploie les ailes");
        }

        public void voler()
        {
            Console.WriteLine("Oiseau: Je vole grâce à mes ailes");
        }
    }
}

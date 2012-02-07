using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Avion : IVolant, IRoulant
    {
        public int NombrePropulseurs { get; set; }
        public void Voler() {
            Console.WriteLine("Je vole grace à :" + NombrePropulseurs + " moteurs");
        }

        public void Rouler() {
            Console.WriteLine("Je roule");
        }

    }
}

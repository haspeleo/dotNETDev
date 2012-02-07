using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public static class ExtensionIVolant  //add method to class or interface when you have no access to the code
    {

        public static void atterir(this IVolant volant) {
            Console.WriteLine("ExtensionIVolant: Je peux attérir !");
        }
    }
}

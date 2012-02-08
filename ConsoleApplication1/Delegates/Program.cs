using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.Beep();
            Console.WriteLine("\n delegates =================================================");

            int[] tableau = new int[] { 12, 1, 8, 4, 6, 9, 10};
            new TrieurDeTableau().demoTri(tableau);


            Console.WriteLine("\n delegates Action and Func==================================");
            new Operations().demoOperations();

            Console.WriteLine("\n lambdas expressions =======================================");
            Console.WriteLine("\nPress a key to exit ...");
            Console.ReadKey(); 
        }
    }
}

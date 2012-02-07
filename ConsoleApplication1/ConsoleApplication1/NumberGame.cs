using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class NumberGame
    {

        private int secretNumber;
        private int trials = 0;

        public NumberGame()
        {
            secretNumber = new Random().Next(0, 100);
        }

        public void guessNumber()
        {

            bool found = false;
            Console.WriteLine("Enter a number in [0, 100]");
            while (!found)
            {
                string saisie = Console.ReadLine();
                int number;
                if (int.TryParse(saisie, out number))
                {

                    if (number == secretNumber)
                    {
                        found = true;
                        Console.WriteLine(">> Number found (O_O) after " + trials + " trial(s)");
                    }
                    if (number < secretNumber)
                    {
                        Console.WriteLine(">> Plus !");
                        found = false;
                    }
                    if (number > secretNumber)
                    {
                        Console.WriteLine(">> Moins !");
                        found = false;
                    }
                    trials++;

                }
                else
                {
                    Console.WriteLine("Incorrect input, please retry!");
                }

            }

        }
	

    }
}

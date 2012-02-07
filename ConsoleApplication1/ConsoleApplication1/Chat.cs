using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Chat : Animal
    {
        public Chat() : base() { }
        public Chat(string prenomChat) : base(prenomChat) { }
        public void miauler()
        {
            Console.WriteLine("Miaou!");
        }

        public override void seDeplacer()
        {
            Console.WriteLine("Chat: je me deplace rapidement"); 
        }
    }
}

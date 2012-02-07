using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaBibliotheque
{
    public class Client
    {
        private string login;
        public string Login
        {
            get { return login;  }
        }

        private string motDePasse;
        public string MotDePasse 
        {
            get { return motDePasse.crypte(); }
        }

        public Client(string loginClient, string motDePasseClient) {

            login = loginClient;
            motDePasse = motDePasseClient; 
        }

    }
}

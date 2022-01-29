using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppBanque
{
   public class Client
    {
		
		public string nom;
		public string prenom;
		public string adresse;
		public List<Compte> listeCompte;

		public Client(string a, string b, string c, List<Compte> Comptes)
        {
			this.nom = a;
			this.prenom = b;
			this.adresse = c;
			this.listeCompte = Comptes;

        }
		
		void addCompte()
        {

        }
	}
}

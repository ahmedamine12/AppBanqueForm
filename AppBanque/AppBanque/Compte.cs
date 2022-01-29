using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanque
{
    public class Compte
    {
        public int num;
        public float solde;
        public Compte(int num ,float solde)
        {
            this.num = num;
            this.solde = solde;
        }
        public float getsolde()
        {
            return this.solde;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppBanque
{
    public partial class ClientInfo : Form
    {
       Client pers;
       
        public ClientInfo(Client per)
        {
            this.pers=per ;
            InitializeComponent();
        }
       
       
        private void ClientInfo_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show(this.pers.nom);
            this.infonom.Text = this.pers.nom;
            this.infoprenom.Text = this.pers.prenom;
            this.indoadresse.Text = this.pers.adresse;
            
            for (int i = 0; i < this.pers.listeCompte.Count;i++ )
            {
                Button btnCompte = new Button();
                btnCompte.Text = "Compte"+(i+1).ToString();
                btnCompte.Name = "Compte" +(i+1).ToString();
                btnCompte.Location = new Point(478, 42 + i*50 + 50);
                this.Controls.Add(btnCompte);
                btnCompte.Click += new EventHandler(ShowInfo);

            }
            
            

            //MessageBox.Show(pers.listeCompte.Count.ToString());
        }
        private void ShowInfo(object sender, EventArgs e)
        {
            
            for(int i=0; i < this.pers.listeCompte.Count; i++)

                if(((Button)sender).Name == "Compte" + (i + 1).ToString())
                {
                    Compte c = new Compte(int.Parse(this.pers.listeCompte[i].num.ToString()), float.Parse(this.pers.listeCompte[i].solde.ToString()));
                    InfoCompte infCompte = new InfoCompte(c);
                    infCompte.Show();

                }
            
        }


    }
}

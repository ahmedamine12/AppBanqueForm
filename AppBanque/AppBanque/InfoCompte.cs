using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanque
{
    public partial class InfoCompte : Form
    {
        Compte c;
        Label solde = new Label();
        public InfoCompte(Compte cpt)
        {
            this.c = cpt;
            InitializeComponent();
        }

        private void InfoCompte_Load(object sender, EventArgs e)
        {
           Label TitreNum = new Label();
          TitreNum.Text = "Numero du Compte";
            TitreNum.Location = new Point(251, 142);
            this.Controls.Add(TitreNum);
         
            Label NumCompte = new Label();
            NumCompte.Text = c.num.ToString();
            NumCompte.Location = new Point (361, 140);
            this.Controls.Add(NumCompte);

            Label titresolde = new Label();
            titresolde.Text = "Votre Solde est : ";
            titresolde.Location = new Point(250, 184);
            this.Controls.Add(titresolde);
            


         
           solde.Text = c.solde.ToString();
          solde.Location = new Point(361, 186);
            this.Controls.Add(solde);

            Button btnRetier = new Button();
            btnRetier.Text = "Retirer";
            btnRetier.Name = "Retirer";
            btnRetier.Location = new Point(254, 288);
            this.Controls.Add(btnRetier);
            btnRetier.Click += new EventHandler(Operation);


            Button btnAdd = new Button();
            btnAdd.Text = "Verser";
            btnRetier.Name = "Retirer";
            btnAdd.Location = new Point(487, 288);
            this.Controls.Add(btnAdd);
            btnAdd.Click += new EventHandler(Operation);


        }
        private void Operation(object sender, EventArgs e)
        {
           
            
            char type;
            if (((Button)sender).Name == "Retirer")
                
            {
                
                type = 'r';

            }
            else
            {
                type = 'v';
            }
            Operations op = new Operations(float.Parse(solde.Text), type);

            OperationInfo opInfo = new OperationInfo(solde ,op );
            opInfo.Show();
           
  
            

           

        }
    }
}

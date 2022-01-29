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
    public partial class OperationInfo : Form
    {
        Operations op;
        Label lab;
        public OperationInfo(Label a, Operations op )
        {
            this.op = op;
            this.lab = a;
            InitializeComponent();
        }
        TextBox valeur = new TextBox();

        private void OperationInfo_Load(object sender, EventArgs e)
        {
            Label Montant = new Label();
            Montant.Text = "Donner le montant que vous voulez  : ";
            Montant.Location = new Point(250, 184);
            this.Controls.Add(Montant);

           
            valeur.Text = "en DH";
            valeur.Name = "valeur";
            this.Controls.Add(valeur);

            Button Valider = new Button();
            Valider.Text = "Valider";
            Valider.Location = new Point(487, 288);
            this.Controls.Add(Valider);
            Valider.Click += new EventHandler(Execution);




        }
        private void Execution(object sender, EventArgs e)
        {
                            MessageBox.Show("c'est clicke");
            if(this.op.type =='r')
            {
                MessageBox.Show("c'est clicke");
                if(float.Parse(valeur.Text) < this.op.solde )
                {
                    this.lab.Text = (this.op.solde - float.Parse(valeur.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("la valeur est plus grande que votre solde");
                }

            }
            else
            {
                this.lab.Text = (this.op.solde + float.Parse(valeur.Text)).ToString();

            }
            // çca reste le changement dans la base de donne 
           // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bouri\OneDrive\Documents\Client.mdf;Integrated Security=True;Connect Timeout=30");
           // SqlDataAdapter comm = new SqlDataAdapter("UPDATE table SET Solde = '"+float.Parse(this.lab.Text)+"'where Num ='"+this.op"'", con);

        }
    }
}

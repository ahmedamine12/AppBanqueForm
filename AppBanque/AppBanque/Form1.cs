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
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bouri\OneDrive\Documents\Client.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter comm = new SqlDataAdapter ("Select * from TableLogin where Username='"+ txtusername.Text+"' and Password = '"+ txtPassword.Text +"'",con);
            DataTable donne = new DataTable();
            comm.Fill(donne);
            // on va verifier si cout =1 donc il ya un client donc on ouvre la page client
            if(donne.Rows[0][0].ToString()!=null)
            {
                //this.Hide();
                int i=0,j;

                SqlDataAdapter comm2 = new SqlDataAdapter("Select * from Compte where idClient = '"+donne.Rows[0][0]+"'", con);
                List<Compte> Comptes =new List<Compte>();
                DataTable donne2 = new DataTable();
                comm2.Fill(donne2);
                while (i < donne2.Rows.Count )
                {
                  
                   
                        Compte temp = new Compte(int.Parse(donne2.Rows[i][1].ToString()),float.Parse(donne2.Rows[i][2].ToString()));

                        Comptes.Add(temp);

                    
                    i++;
                    

                }


            
                Client c1 = new Client(donne.Rows[0][3].ToString(), donne.Rows[0][4].ToString(), donne.Rows[0][5].ToString(), Comptes);
                 ClientInfo info = new ClientInfo(c1);
                // MessageBox.Show(donne.Rows[0][5].ToString());
                info.Show();
              this.Owner = info;
               this.Hide();


            }
            else 
            {
                MessageBox.Show("Username or Password is incorrect. please try");
            }
        }
    }
}

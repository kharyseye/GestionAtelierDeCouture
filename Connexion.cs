using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Atelier_Couture.model;

namespace Gestion_Atelier_Couture
{
    public partial class Connexion : Form
    {bdgescouturEntities db = new bdgescouturEntities();    
        public Connexion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            /*FrmClient c = new FrmClient();
            c.Show();*/
            try
            {
                if(db.Login.Where(r => r.utilisateur== txtuser.Text 
                && r.mdpasse == txtmdp.Text).Count() > 0)
                {
                    MessageBox.Show("Authentification reussie");
                    FrmClient c = new FrmClient();
                    c.Show();
                }
                else
                {
                    MessageBox.Show("identifiant ou mot de passe incorrect");
                }
              
            }
            catch(Exception ert)
            {

            }
        }
    }
}

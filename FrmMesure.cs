using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Atelier_Couture
{
    public partial class FrmMesure : Form
    {
        public string sexe;
        public int idClient;
        public FrmMesure()
        {
            InitializeComponent();
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void FrmMesure_Load(object sender, EventArgs e)
        {
            if (sexe == "Femme")
            {
                pnFemme.Visible = false;
            }
            else
            {
                pnFemme.Visible = true;
            }
        }
    }
}

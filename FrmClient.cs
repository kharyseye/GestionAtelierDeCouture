using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Atelier_Couture.Model;

namespace Gestion_Atelier_Couture
{
    public partial class FrmClient : Form
    {
       bdCoutureEntities db = new bdCoutureEntities();
        public FrmClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void NomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModele_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void FrmClient_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
          Personne p = new Personne();
          Client c = new Client();
            p.NomPers = txtNom.Text;
            p.PrenomPers= txtPrenom.Text;
            p.AdressePers= txtAdresse.Text;
            p.EmailPers= txtEmail.Text;
            p.TelPers = txtEmail.Text;
          
            db.Personne.Add(p);
            db.SaveChanges();
            var id = db.Personne.Max(x=> x.Id );
            c.Id = id;
            c.Genre = cbbGenre.Text;
            db.Client.Add(c);
            db.SaveChanges();
            MessageBox.Show("Ajouté avec succés");
            

        }

       
    }
}

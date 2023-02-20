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
    public partial class FrmClient : Form
    {
        bdgescouturEntities db;
        //private Button currentButton;
        public FrmClient()
        {
            InitializeComponent();
        }
        
        private void FrmClient_Load(object sender, EventArgs e)
        {
            db = new bdgescouturEntities();
            dgvClient.DataSource = db.ViewClient.ToList();
        }
        private void effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            cbbGenre.Text = string.Empty;
            dgvClient.DataSource = db.ViewClient.ToList();
            txtNom.Focus();
        }

       /* private void activebuttun(object btnsender) 
        {
            if(btnsender != null)
            {
                if(currentButton != (Button)btnsender)
                {
                    currentButton = (Button)btnsender;
                }
            }
            
        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgvClient.CurrentRow.Cells[0].Value.ToString());
            Personne p = db.Personne.Find(id);
            db.Personne.Remove(p);
            db.SaveChanges();
            Client c = db.Client.Find(id);
            db.Client.Remove(c);
            db.SaveChanges();
            MessageBox.Show("supprimé evec succes");
            effacer();
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Personne p = new Personne();
            p.NomPers = txtNom.Text;
            p.PrenomPers = txtPrenom.Text;
            p.AdressPers = txtAdresse.Text;
            p.TelPers = txtTelephone.Text;
            p.EmailPers = txtEmail.Text;
            db.Personne.Add(p);
            db.SaveChanges();
            Client c = new Client();            
            c.idPers = p.idPers;
            c.Genre = cbbGenre.Text;
            db.Client.Add(c);
            db.SaveChanges();
            MessageBox.Show("ajouté evec succes");
            effacer();
        }

        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            txtAdresse.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            txtTelephone.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
            cbbGenre.Text = dgvClient.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgvClient.CurrentRow.Cells [0].Value.ToString());
            Personne p = db.Personne.Find(id);
            p.NomPers = txtNom.Text;
            p.PrenomPers = txtPrenom.Text;
            p.AdressPers = txtAdresse.Text;
            p.EmailPers = txtEmail.Text;
            p.TelPers = txtTelephone.Text;
            db.SaveChanges();
            Client c = db.Client.Find(id);
            c.Genre = cbbGenre.Text;
            db.SaveChanges();
            MessageBox.Show("modification enregistrée");
            effacer();
        }

        private void dgvClient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FrmClient c = new FrmClient();
            c.Show();
        }

        private void btnMesure_Click(object sender, EventArgs e)
        {
            FrmMesure m = new FrmMesure();
            m.Show();
            this.Hide();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion con = new Connexion();
            con.Show();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.ViewClient.ToList();
            if (!string.IsNullOrEmpty(txtNom.Text))
            {
                liste = liste.Where(x => x.NomPers.ToUpper().Contains(txtNom.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(txtPrenom.Text))
            {
                liste = liste.Where(x => x.PrenomPers.ToUpper().Contains(txtPrenom.Text.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(cbbGenre.Text))
            {
                liste = liste.Where(x => x.Genre==cbbGenre.Text).ToList();
            }
            dgvClient.DataSource = liste.ToList();

        }

        private void btnMesurer_Click(object sender, EventArgs e)
        {
            FrmMesure f = new FrmMesure();
            f.idPers = int.Parse(dgvClient.CurrentRow.Cells[0].Value.ToString());
            f.sexe = dgvClient.CurrentRow.Cells[6].Value.ToString().Trim();
            f.Show();
        }
    }
}

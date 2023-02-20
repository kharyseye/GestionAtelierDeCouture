using Gestion_Atelier_Couture.App_Code;
using Gestion_Atelier_Couture.model;
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
        public int idPers;
        bdgescouturEntities db = new bdgescouturEntities();

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
                pnFemme.Visible = true;
                var m = db.Mesure.Find(idPers);
                var compM = db.ComplementMesurefemme.Find(idPers);

                if (m != null)
                 {
                    txtAvantbras.Text = m.avantBras.ToString();
                    txtTete.Text = m.tete.ToString();
                    txtcou.Text = m.cou.ToString();
                    txtEpaule.Text = m.epaule.ToString();
                    txtBras.Text = m.LBras.ToString();
                    txtPoitrine.Text = m.poitrine.ToString();
                    txtHanche.Text = m.hanches.ToString();
                    txtLcorps.Text = m.LCorps.ToString();
                    txtCuisse.Text = m.cuisse.ToString();
                    txtGenoux.Text = m.genou.ToString();
                    txtMollet.Text = m.mollet.ToString();
                    txtCheville.Text = m.cheville.ToString();
                    txtbiceps.Text = m.biceps.ToString();
                    txtCoude.Text = m.coude.ToString();
                    txtAvantbras.Text = m.avantBras.ToString();
                    txtxPoigneCoude.Text = m.poignetCoude.ToString();
                    txtEntreJambe.Text = m.entreJambe.ToString();
                    txtCoutureExt.Text = m.coutureExt.ToString();
                    txtHauteurTotal.Text = m.hTotale.ToString();
                    if (sexe == "Femme")
                    {
                        txtLdos.Text = compM.LDos.ToString();
                        txtDessousPoitrine.Text = compM.dessousPoit.ToString();
                        txtCreteslliaque.Text = compM.creteslliaque.ToString();
                    }
                }
                
            }
            else
            {
                pnFemme.Visible = false;
            }
        }

        private void pnFemme_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool existM = true;
            var m = db.Mesure.Find(idPers);
            var compM = db.ComplementMesurefemme.Find(idPers);
            if (m == null)
            {
                m = new Mesure();
                m.idClient = idPers;
                if (sexe == "Femme")
                {
                    compM = new ComplementMesurefemme();
                    compM.idClient = idPers;
                }
            }
            else
            {
                existM = false;
            }
            m.cou = Helpers.ConvertStringToFloat(txtcou.Text);
            m.avantBras = Helpers.ConvertStringToFloat(txtAvantbras.Text);
            m.biceps = Helpers.ConvertStringToFloat(txtbiceps.Text);
            m.cheville = Helpers.ConvertStringToFloat(txtCheville.Text);
            m.coude = Helpers.ConvertStringToFloat(txtCoude.Text);
            m.coutureExt = Helpers.ConvertStringToFloat(txtCoutureExt.Text);
            m.cuisse = Helpers.ConvertStringToFloat(txtCuisse.Text);
            m.entreJambe = Helpers.ConvertStringToFloat(txtEntreJambe.Text);
            m.epaule = Helpers.ConvertStringToFloat(txtEpaule.Text);
            m.genou = Helpers.ConvertStringToFloat(txtGenoux.Text);
            m.hanches = Helpers.ConvertStringToFloat(txtHanche.Text);
            m.hTotale = Helpers.ConvertStringToFloat(txtHauteurTotal.Text);
            m.LBras = Helpers.ConvertStringToFloat(txtBras.Text);
            m.LCorps = Helpers.ConvertStringToFloat(txtLcorps.Text);
            m.mollet = Helpers.ConvertStringToFloat(txtMollet.Text);
            m.poignetCoude = Helpers.ConvertStringToFloat(txtxPoigneCoude.Text);
            m.poitrine = Helpers.ConvertStringToFloat(txtPoitrine.Text);
            m.tete = Helpers.ConvertStringToFloat(txtTete.Text);

            if (sexe == "Femme")
            {
                compM.dessousPoit = Helpers.ConvertStringToFloat(txtDessousPoitrine.Text);
                compM.creteslliaque = Helpers.ConvertStringToFloat(txtCreteslliaque.Text);
                compM.LDos = Helpers.ConvertStringToFloat(txtLdos.Text);

            }

            if (existM)
            {
                db.Mesure.Add(m);
                if (sexe == "Femme")
                {
                    db.ComplementMesurefemme.Add(compM);
                }
            }
            db.SaveChanges();
        }
    }
}

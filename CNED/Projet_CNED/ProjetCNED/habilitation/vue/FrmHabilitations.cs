using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Habilitations.controleur;
using Habilitations.modele;
namespace Habilitations.vue
{
    public partial class FrmHabilitations : Form
    {
        private Controle controle;

        public BindingSource bdgDev = new BindingSource();

        public BindingSource bdgProfil = new BindingSource();
        public FrmHabilitations(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            FrmHabilitations_Load();
        }

        public void FrmHabilitations_Load()
        {
            RemplirListeDev();
            RemplirListeProfils();
            grpChangerpwd.Enabled = false;

        }

        public void RemplirListeDev()
        {
            // Lier la liste lesDev avec le lien bdgDev
            List<Developpeur> lesDev = controle.GetLesDeveloppeurs();
            bdgDev.DataSource = lesDev;
            dataGridDev.DataSource = bdgDev;

            dataGridDev.Columns["iddeveloppeur"].Visible = false;
            dataGridDev.Columns["idprofil"].Visible = false;
            dataGridDev.Columns["pwd"].Visible = false;
        }

        public void RemplirListeProfils()
        {
            // lier la liste de profil au lien bdgProfil
            List<Profil> lesProfils = controle.GetLesProfils();
            bdgProfil.DataSource = lesProfils;
            cobProfil.DataSource = bdgProfil;

            if(cobProfil.Items.Count > 0)
            {
                cobProfil.SelectedIndex = 0;
            }
        }

        private void btnsuppr_Click(object sender, EventArgs e)
        {
            if(dataGridDev.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDev.List[bdgDev.Position];
                if(MessageBox.Show("Supprimer?"+ developpeur.Nom + "  "+ developpeur.Prenom, "confirmer supp?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelDeveloppeur(developpeur);
                    RemplirListeDev();
                }
                
            }
            else
            {
                MessageBox.Show("selectionner une ligne", "Information suppression");
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Developpeur unnvdev = new Developpeur(txt);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCned.controleur;
using ProjetCned.modele;

namespace ProjetCned.vue
{
    /// <summary>
    /// Fenêtre d'affichage et de gestion du personnel et de leurs absences
    /// </summary>
    public partial class FrmGestion : Form
    {
        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;


        /// <summary>
        /// Objet de gestion de la liste du personnel
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();


        /// <summary>
        /// Objet de gestion de la liste des services
        /// </summary>
        BindingSource bdgService = new BindingSource();


        /// <summary>
        /// Objet de gestion de la liste des absences
        /// </summary>
        BindingSource bdgAbs = new BindingSource();


        /// <summary>
        /// Objet de gestion de la liste des motifs d'absence
        /// </summary>
        BindingSource bdgMotif = new BindingSource();


        /// <summary>
        /// Variable de gestion des enregistrements
        /// </summary>
        private Boolean ModifenCours = false;



        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération de l'instance du controleur
        /// Initialisation de l'affichage
        /// </summary>
        /// <param name="controle">instance du controleur</param>
        public FrmGestion(Controle controle)
        {
            InitializeComponent();

            this.controle = controle;

            Init();

        }



        /// <summary>
        /// Rend non accessible les groupes absence et gestion du personnel
        /// Affiche
        /// </summary>
        public void Init()
        {
            grpabsence.Enabled = false;
            grpGestionPers.Enabled = false;

            AfficherListePersonnel();
            AfficherService();
        }



        /// <summary>
        /// Initialisation de la liste du personnel et affiche la liste du personnel
        /// </summary>
        public void AfficherListePersonnel()
        {
            List<Personnel> lesPersonnels = controle.GetPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dataPersonnel.DataSource = bdgPersonnel;

            dataPersonnel.Columns["idpersonnel"].Visible = false;
            dataPersonnel.Columns["idservice"].Visible = false;
            dataPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }



        /// <summary>
        /// Afficher  la liste des services dans cobService
        /// </summary>
        public void AfficherService()
        {
            List<Service> lesServices = controle.GetService();
            bdgService.DataSource = lesServices;
            cobservice.DataSource = bdgService;

            if (cobservice.Items.Count > 0)
            {
                cobservice.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// Event Click sur Ajouter un personnel à la grille
        /// Rend accessible les boutons de gestion
        /// Récupére la liste des services
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPers_Click(object sender, EventArgs e)
        {
            grpGestionPers.Enabled = true;

        }



        /// <summary>
        /// Evenement click sur btnEnregisterPers
        /// Gére l'enregistrement des données saisies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPers_Click(object sender, EventArgs e)
        {
            Service service = (Service)bdgService.List[bdgService.Position];

            if (!txtnom.Text.Equals("") && !txtprenom.Text.Equals("") && !txttel.Text.Equals("") && !txtmail.Text.Equals("") && cobservice.SelectedIndex != -1)
            {
                int idpersonnel = 0;
                if (ModifenCours)
                {
                    idpersonnel = (int)dataPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel unPersonnel = new Personnel(idpersonnel, txtnom.Text, txtprenom.Text, txttel.Text, txtmail.Text, service.Idservice, service.Nom);
                if (ModifenCours)
                {
                    controle.ModPersonnel(unPersonnel);
                    MessageBox.Show(unPersonnel.Nom + " " + unPersonnel.Service, "fenetre test");
                    ModifenCours = false;
                    grpGestionPers.Enabled = true;
                }
                else
                {
                    controle.AddPersonnel(unPersonnel);
                }
                AfficherListePersonnel();
                Vider();
            }
            else
            {
                MessageBox.Show("Il faut remplir tout les champ avant validation", "Erreur de saisie");
            }


        }


        /// <summary>
        /// Evenement click sur btnAnnulerPers
        /// Gére l'annulation d'un ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPers_Click(object sender, EventArgs e)
        {
            if (dataPersonnel.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez vous vraiment annuler la saisie?", "Annulation ajouter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Vider();

                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }



        /// <summary>
        /// Vider les champs de textes
        /// </summary>
        private void Vider()
        {
            // Vider champs
            txtnom.Text = "";
            txtprenom.Text = "";
            txttel.Text = "";
            txtmail.Text = "";
            cobservice.SelectedIndex = 0;

            //fermer gestionPers
            grpGestionPers.Enabled = false;
        }



        /// <summary>
        /// Evenement click sur btnSupprPers
        /// Gére la suppression d'un personnel apres validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprPers_Click(object sender, EventArgs e)
        {
            if (dataPersonnel.SelectedRows.Count > 0)
            {
                Personnel unpersonnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer " + unpersonnel.Nom + " " + unpersonnel.Prenom + " du service " + unpersonnel.Service + "?", "Confirmation suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(unpersonnel);
                    AfficherListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne", "Information");
            }
        }



        /// <summary>
        /// Evenement Click sur btnModifierPers
        /// Gére les zones d'affichages pour la modification d'un personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPers_Click(object sender, EventArgs e)
        {
            if (dataPersonnel.SelectedRows.Count > 0)
            {
                grpGestionPers.Enabled = true;
                ModifenCours = true;

                Personnel unpersonnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];

                txtnom.Text = unpersonnel.Nom;
                txtprenom.Text = unpersonnel.Prenom;
                txtmail.Text = unpersonnel.Mail;
                txttel.Text = unpersonnel.Tel;
                cobservice.SelectedIndex = cobservice.FindStringExact(unpersonnel.Service);
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne", "Information");
            }
        }



        /// <summary>
        /// Evenement click sur btnGestionAbs
        /// Gére l'affichage des groupes
        /// Appelle les méthodes d'affichage des absences et motif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestionAbs_Click(object sender, EventArgs e)
        {
            if (dataPersonnel.SelectedRows.Count > 0)
            {
                grpGestionPers.Enabled = false;
                grpabsence.Enabled = true;
                grpGestionAbs.Enabled = true;

                Personnel unpersonnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                MessageBox.Show(unpersonnel.Nom);
                AfficherAbs(unpersonnel);
                AfficherMotif();
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne", "Information");
            }
        }



        /// <summary>
        /// Afficher la liste des abscences d'un personnel dans dataAbsence
        /// </summary>
        /// <param name="unpersonnel"></param>
        public void AfficherAbs(Personnel unpersonnel)
        {
            List<Absence> lesabs = controle.GetAbsences(unpersonnel);
            bdgAbs.DataSource = lesabs;
            dataAbsence.DataSource = bdgAbs;

        }



        /// <summary>
        /// Afficher la liste des motifs dans cobMotif
        /// </summary>
        public void AfficherMotif()
        {
            List<Motif> lesMotifs = controle.GetMotifs();
            bdgMotif.DataSource = lesMotifs;
            cobMotif.DataSource = bdgMotif;

        }


    }
}

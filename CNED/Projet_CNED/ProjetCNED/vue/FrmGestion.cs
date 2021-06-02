using ProjetCned.controleur;
using ProjetCned.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        private Boolean ModifPers = false;

        private Boolean ModifAbs = false;

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
                if (ModifPers)
                {
                    idpersonnel = (int)dataPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel unPersonnel = new Personnel(idpersonnel, txtnom.Text, txtprenom.Text, txttel.Text, txtmail.Text, service.Idservice, service.Nom);
                if (ModifPers)
                {
                    controle.ModPersonnel(unPersonnel);
                    ModifPers = false;
                    grpGestionPers.Enabled = true;
                }
                else
                {
                    controle.AddPersonnel(unPersonnel);
                }
                AfficherListePersonnel();
                ViderPers();
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

            ViderPers();
            grpGestionPers.Enabled = false;
        }



        /// <summary>
        /// Vider les champs de textes
        /// </summary>
        private void ViderPers()
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
                ModifPers = true;

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
                grpGestionAbs.Enabled = false;

                Personnel unpersonnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
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

            dataAbsence.Columns["idpersonnel"].Visible = false;
            dataAbsence.Columns["idmotif"].Visible = false;
            dataAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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


        /// <summary>
        /// Evenement click sur btnAjouterAbs
        /// Gére l'affichage des zones de saisies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterAbs_Click(object sender, EventArgs e)
        {
            grpGestionAbs.Enabled = true;

        }


        /// <summary>
        /// Evenement click btnEnregistrerAbs
        /// Enregistre les données saisies et met l'affichage à jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAbs_Click(object sender, EventArgs e)
        {
            if ((dateDebut.Value < dateFin.Value) && (cobMotif.SelectedIndex != -1))
            {
                Personnel lepersonnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                Motif lemotif = (Motif)bdgMotif.List[bdgMotif.Position];
                Absence uneAbsence = new Absence(lepersonnel.Idpersonnel, dateDebut.Value, dateFin.Value, lemotif.Libelle, lemotif.Idmotif);

                if (ModifAbs)
                {
                    controle.ModAbsdebut(uneAbsence);
 
                    uneAbsence = new Absence(lepersonnel.Idpersonnel, uneAbsence.Datedebut, dateFin.Value, lemotif.Libelle, lemotif.Idmotif);

                    controle.ModAbs(uneAbsence);
                
                    ModifAbs = false;
                }
                else
                {
                    controle.AddAbsence(uneAbsence);
                }


                AfficherAbs(lepersonnel);

            }
            else
            {
                MessageBox.Show("Champs non valides", "Erreur Saisie");
            }

            grpGestionAbs.Enabled = false;
            ViderAbs();
        }



        /// <summary>
        /// Evenement Click  sur btnAnnulerAbs
        /// Annuler la saisie d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbs_Click(object sender, EventArgs e)
        {
            ViderAbs();
        }


        /// <summary>
        /// Vider les saisies et fermer le grpGestionAbs
        /// </summary>
        public void ViderAbs()
        {
            dateDebut.Value = DateTime.Today;
            dateFin.Value = DateTime.Today;
            cobMotif.SelectedIndex = 0;

            grpGestionAbs.Enabled = false;
        }



        /// <summary>
        /// Evenement click sur btnSupprAbs
        /// Supprimer une absence d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprAbs_Click(object sender, EventArgs e)
        {
            if (dataAbsence.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbs.List[bdgAbs.Position];
                if (MessageBox.Show("Etes vous sur de vouloir supprimer l'absence du" + absence.Datedebut + " au " + absence.Datefin + " pour " + absence.Motif + "?", "Validation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbs(absence);
                }

                Personnel unpersonnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                AfficherAbs(unpersonnel);
                ViderAbs();
            }
            else
            {
                MessageBox.Show("Sélectionner une ligne", "Erreur Sélection");
            }
        }



        /// <summary>
        /// Event click sur btnModifierAbs
        /// Gerer la modification d'une absence selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbs_Click(object sender, EventArgs e)
        {
            if (dataAbsence.SelectedRows.Count == 1)
            {
                Absence uneabsence = (Absence)bdgAbs.List[bdgAbs.Position];

                dateDebut.Value = uneabsence.Datedebut;
                dateFin.Value = uneabsence.Datefin;
                cobMotif.SelectedIndex = cobMotif.FindStringExact(uneabsence.Motif);

                grpGestionAbs.Enabled = true;
                ModifAbs = true;
            }
            else
            {
                MessageBox.Show("Selectionner une ligne", "Information");
            }
        }
   
    }
}

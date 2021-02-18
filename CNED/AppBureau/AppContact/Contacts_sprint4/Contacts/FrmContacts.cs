using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Contacts
{
    /// <summary>
    /// Classe frmContacts
    /// Formulaire des contacts
    /// </summary>
    public partial class frmContacts : Form
    {
        // liste des contacts
        private List<Contact> lesContacts = new List<Contact>();
        // nom sérialisation
        private string fichier = "ficcontact";

        /// <summary>
        /// Constructeur
        /// </summary>
        public frmContacts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Préparer l'ajout en gérant les objets graphiques
        /// </summary>
        private void DebutAjout()
        {
            // Gérer les accès aux objets graphiques
            grbAjout.Enabled = true;
            grbContacts.Enabled = false;
            imgPhoto.Enabled = true;
            btnNouveauContact.Enabled = false;
            lblChoixPhoto.Visible = true;
            grpRecherche.Enabled = false;

            // désactiver la ligne sélectionnée dans la liste
            lstContact.SelectedIndex = -1;

            // affiche la photo standard
            AffichePhotoStandard();

            // se positionner sur le nom
            txtNom.Focus();
        }


        /// <summary>
        /// Préparer l'après ajout en gérant les objets graphiques
        /// </summary>
        private void FinAjout()
        {
            // Gérer les accès aux objets graphiques
            grbAjout.Enabled = false;
            grbContacts.Enabled = true;
            imgPhoto.Enabled = false;
            btnNouveauContact.Enabled = true;
            lblChoixPhoto.Visible = false;
            grpRecherche.Enabled = true;

            // sélectionner bouton radio Particulier par défaut
            rdbParticulier.Checked = true;

            // vider les zones de saisie
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";

            // se positoinner sur la liste
            lstContact.Focus();
        }


        /// <summary>
        /// se positionner sur la ligne demandée en paramètre ou la 1e ligne si la liste n'est pas vide
        /// </summary>
        /// <param name="ligne">ligne à sélectionner</param>
        private void PositionDansListe(String ligne)
        {
            try
            {
                if (ligne != null)
                {
                    int index = lstContact.FindStringExact(ligne);
                    lstContact.SelectedIndex = index;
                }
                else
                {
                    lstContact.SelectedIndex = 0;
                }
            }
            catch
            {
                lstContact.SelectedIndex = -1;
            }
        }


        /// <summary>
        /// Mettre à jour la listbox avec tous les contacts
        /// et si demandé, se positionner sur la ligne reçue en paramètre
        /// </summary>
        /// <param name="ligne">ligne à sélectionner</param>
        private void MajListBox(String ligne)
        {
            // trier la liste
            lesContacts.Sort();

            // lier la ListBox avec lesContacts pour la remplir
            BindingList<Contact> bdlContacts = new BindingList<Contact>(lesContacts);
            lstContact.DataSource = bdlContacts;

            // si le dictionnaire est vide, mettre la photo vide
            if (lesContacts.Count == 0)
            {
                VidePhoto();
            }

            // sauver la liste dans le fichier
            Serialise.Sauve(fichier, lesContacts);

            // se positionner sur la ligne demandée en paramètre ou la 1e ligne si la liste n'est pas vide
            PositionDansListe(ligne);
        }


        /// <summary>
        /// Au changement de choix du type de contact
        /// afficher ou non la zone du prénom 
        /// </summary>
        private void ChangeTypeContact()
        {
            // afficher le prénom si Pariculier, ou non si Professionnel
            lblPrenom.Visible = rdbParticulier.Checked;
            txtPrenom.Visible = rdbParticulier.Checked;
        }


        /// <summary>
        /// Vider l'affichage de la photo (afficher une photo blanche)
        /// </summary>
        private void VidePhoto()
        {
            imgPhoto.Image = Properties.Resources.vide;
        }


        /// <summary>
        /// Afficher la photo standard
        /// </summary>
        private void AffichePhotoStandard()
        {
            imgPhoto.Image = Properties.Resources.standard;
        }


        /// <summary>
        /// Supprimer le contact donc l'index est reçu en paramètre
        /// </summary>
        /// <param name="index">index du contact à supprimer</param>
        private void SupprContact(int index)
        {
            if (index != -1)
            {
                lesContacts.RemoveAt(index);
                MajListBox(null);
            }
        }


        /// <summary>
        /// Evénement Click sur le bouton bntSuppr
        /// Supprimer le contact sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            //  contrôler qu'une ligne est bien sélectionnée
            if (lstContact.SelectedIndex != -1)
            {
                // demander une confirmation de suppression
                if (MessageBox.Show("Supprimer le contact ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // supprimer le contact sélectionné
                    SupprContact(lstContact.SelectedIndex);
                }
            }
        }

        /// <summary>
        /// Evénement sélection d'un contact dans la lstContact
        /// Charger la photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si une ligne est sélectionnée
            if (lstContact.SelectedIndex != -1)
            {
                Contact leContact = lesContacts[lstContact.SelectedIndex];
                // afficher l'image
                imgPhoto.Image = leContact.getPhoto();
            }
            else
            {
                // affiche une image vide
                VidePhoto();
            }
        }


        /// <summary>
        /// Evénement clic sur bouton btnAjouter
        /// Ajouter le contact dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            // vérifier que le nom, prénom et tel ne sont pas vides 
            if (!txtNom.Text.Equals("") && !txtTel.Text.Equals("") &&
                ((rdbParticulier.Checked && !txtPrenom.Text.Equals("")) || rdbProfessionnel.Checked))
            {
                // créer le contact
                Contact nouveauContact;
                if (rdbParticulier.Checked)
                {
                    nouveauContact = new Particulier(txtNom.Text, txtPrenom.Text, txtTel.Text, imgPhoto.Image);
                }
                else
                {
                    nouveauContact = new Professionnel(txtNom.Text, txtTel.Text, imgPhoto.Image);
                }
                // ajouter le contact dans la collection
                lesContacts.Add(nouveauContact);

                // mettre à jour de la ListBox
                MajListBox(nouveauContact.ToString());

                // gérer la fin de l'ajout au niveau des objets graphiques
                FinAjout();
            }
            else
            {
                MessageBox.Show("Toutes les zones sont obligatoires");
            }
        }


        /// <summary>
        /// Evénement clic sur le bouton btnModif
        /// Supprimer le contact et transférer ces informations dans la zone d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModif_Click(object sender, EventArgs e)
        {
            // contrôler si un contact est sélectionné
            if (lstContact.SelectedIndex != -1)
            {
                grpRecherche.Enabled = false;

                // récupérer l'index du contact
                int index = lstContact.SelectedIndex;

                // récupérer le contact concerné
                Contact leContact = lesContacts[index];

                // supprimer le contact
                SupprContact(index);

                // remplir les zones d'ajout avec les informations du contact
                txtNom.Text = leContact.getNom();
                if (leContact is Particulier)
                {
                    txtPrenom.Text = ((Particulier)leContact).getPrenom();
                    rdbParticulier.Checked = true;
                }
                else
                {
                    rdbProfessionnel.Checked = true;
                }
                txtTel.Text = leContact.getTel();
                // gérer le début de l'ajout au niveau des objets graphiques
                DebutAjout();

                // mettre la photo du contact
                imgPhoto.Image = leContact.getPhoto();
            }
        }


        /// <summary>
        /// Evénement chargement de frmContacts
        /// Préparer les composants et récupérer la sérialisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmContacts_Load(object sender, EventArgs e)
        {
            // préparer les composants graphiques comme pour la fin d'un ajout
            FinAjout();

            // récupérer la sauvegarde des contacts, si elle existe
            Object recupContacts = Serialise.Recup(fichier);
            if (recupContacts != null)
            {
                lesContacts = (List<Contact>)recupContacts;
                // remplir de la listbox avec les contacts récupérés
                MajListBox(null);
            }
        }


        /// <summary>
        /// Evénement Click sur le bouton btnAnnuler
        /// Annuler la tentative d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attention les informations seront perdues.", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // gérer la fin de l'ajout au niveau des objets graphiques
                FinAjout();

                // mettre à jour la listbox
                MajListBox(null);
            }
        }

        /// <summary>
        /// Evénement Click sur la photo
        /// possibilité de sélectionner une photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgPhoto_Click(object sender, EventArgs e)
        {
            // boite de dialogue pour sélectionner un fichier
            OpenFileDialog rechercheFichier;
            rechercheFichier = new OpenFileDialog();
            DialogResult choix = rechercheFichier.ShowDialog();

            // si un fichier est sélectionné
            if (choix == DialogResult.OK)
            {
                // récupérer fichier
                string nomFichier = rechercheFichier.FileName;

                // tente d'afficher l'image
                try
                {
                    imgPhoto.Image = Image.FromFile(nomFichier);
                }
                catch
                {
                    // erreur le fichier n'est pas une image
                    MessageBox.Show("Le fichier n'est pas une image");
                }
            }
        }


        /// <summary>
        /// Evénement Click sur le label lblChoixPhoto
        /// mêmes traitements que le clic sur la photo
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void LblChoixPhoto_Click(object sender, EventArgs e)
        {
            ImgPhoto_Click(null, null);
        }


        /// <summary>
        /// Evénement Click sur le bouton btnNouveauContact
        /// Permettre d'ajouter un contact
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            DebutAjout();
        }


        /// <summary>
        /// Evénement Click sur bouton radio rdbParticulier
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void rdbParticulier_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTypeContact();
        }


        /// <summary>
        /// Evénement Click sur bouton radio rdbProfessionnel
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void rdbProfessionnel_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTypeContact();
        }


        /// <summary>
        /// liste avec des couleurs de repére selon type de contact
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void lstContact_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Dessin du fond pour list item
            e.DrawBackground();

            // Recupérer le contact dans notre List de contact
            if (e.Index >= 0)
            {
                Contact nvcontact = lesContacts[e.Index];
                // Récupérer la couleur assigné à son radbtn
                Color couleur;
                if (nvcontact is Particulier)
                {
                    couleur = rdbParticulier.ForeColor;
                }
                else
                {
                    couleur = rdbProfessionnel.ForeColor;
                }

                //Définir la couleur du Pinceau
                Brush nvBrush = new SolidBrush(couleur);

                // Dessiner l'item en cours
                e.Graphics.DrawString(lstContact.Items[e.Index].ToString(), e.Font, nvBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        /// <summary>
        /// Methode de recherche par nom
        /// </summary>
        private void Ft_RechercheNom()
        {
            for (int index = 0; index < lstContact.Items.Count; index++)
            {
                Contact uncontact = lesContacts[index];
                if (uncontact.getNom().ToLower().Contains(txtRecNom.Text.ToLower()))
                {
                    lstContact.SelectedIndex = index;
                    break;
                }
                else
                {
                    lstContact.SelectedIndex = -1;
                }
            }

        }


        /// <summary>
        /// Mrthode de recherche  par prenom.
        /// </summary>
        private void Ft_RecherchePrenom()
        {
            for (int index = 0; index < lstContact.Items.Count; index++)
            {
                Contact lecontact = lesContacts[index];
                if (lecontact is Particulier && ((Particulier)lecontact).getPrenom().ToLower().Contains(txtRecPrenom.Text.ToLower()))
                {
                    lstContact.SelectedIndex = index;
                    break;

                }
                else
                {
                    lstContact.SelectedIndex = -1;
                }
            }
        }


        /// <summary>
        /// Methode de Recherche par telephone
        /// </summary>
        private void Ft_RechercheTel()
        {
            for (int index = 0; index < lstContact.Items.Count; index++)
            {
                Contact lecontact = lesContacts[index];

                if (lecontact.getTel().ToLower().Contains(txtRechTel.Text.ToLower()))
                {
                    lstContact.SelectedIndex = index;
                    break;
                }
                else
                {
                    lstContact.SelectedIndex = -1;
                }
            }


        }


        /// <summary>
        /// Event pour recherche par nom
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void txtRecNom_TextChanged(object sender, EventArgs e)
        {
            if (txtRecNom.Text != "")
            {
                txtRechTel.Text = "";
                txtRecPrenom.Text = "";
                Ft_RechercheNom();
            }

        }


        /// <summary>
        /// Event de recherche du prenom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecPrenom_TextChanged(object sender, EventArgs e)
        {
            txtRecNom.Text = "";
            txtRechTel.Text = "";
            if (txtRecPrenom.Text != "")
            {
                Ft_RecherchePrenom();
            }

        }


        /// <summary>
        /// Event de recherche du Telephone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRechTel_TextChanged(object sender, EventArgs e)
        {
            txtRecNom.Text = "";
            txtRecPrenom.Text = "";
            if (txtRechTel.Text != "")
            {
                Ft_RechercheTel();
            }
        }
    }
}

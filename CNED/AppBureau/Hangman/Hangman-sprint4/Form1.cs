using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hangman_sprint1
{
    public partial class FrmHangman : System.Windows.Forms.Form
    {
        // Variables 
        private string word;
        private string namePic = "";
        private int nbTentative = 0;

        public FrmHangman()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creer les boutons de l'alphabet
        /// </summary>
        private void CreaButton()
        {
            int hIndex;
            int lIndex;
            for (int index = 0; index < 26; index++)
            {
                // Déclaration bouton
                Button btnLetter = new Button();

                // Ajouter le btn au groupe Player2
                grb2.Controls.Add(btnLetter);

                /* Position btn */
                // Gestion position des boutons 
                if (index < 13)
                {
                    lIndex = 5 + 30 * index;
                    hIndex = 30;
                }
                else
                {
                    lIndex = 5 + 30 * (index - 13);
                    hIndex = 60;

                }
                btnLetter.Location = new Point(lIndex, hIndex);

                // Size btn
                btnLetter.Size = new Size(30, 30);

                // Text btn
                btnLetter.Text = ((char)('A' + index)).ToString();

                // Ecouteur sur l'event Click
                btnLetter.Click += new EventHandler(btnLetter_Click);
            }
        }

        /// <summary>
        /// Evenement au chargement de la fenetre
        /// création boutons et lettres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHangman_Load(object sender, EventArgs e)
        {
            // Partie P1
            txtWord1.Text = "";
            txtWord1.Focus();
            grb1.Enabled = true;
            word = "";

            // Partie J2
            CreaButton();
            grb2.Enabled = false;
            nbTentative = 0;
            pibPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0");
            lblLettresRestants.Text = "";
        }


        /// <summary>
        /// Gestion de la lettre si click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLetter_Click(object sender, EventArgs e)
        {

            // Recupérer l'objet concerné par le click
            Button chxLetter = (Button)sender;
            char lettre = char.Parse(chxLetter.Text);

            // Griser BtnLetter
            chxLetter.Enabled = false;

            // Gestion: Trouver la letter
            if (txtWord1.Text.Contains('-') && nbTentative < 10) // En cours de Jeu
            {
                // Si faux: Incrémentation + Change image + Afficher lettre testée sur label
                if (!Ft_FindLetter(lettre))
                {
                    nbTentative++;
                    namePic = "pendu" + nbTentative;
                    pibPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject(namePic);
                }
            }

            // Gestion Partie
            if (nbTentative >= 10 && txtWord1.Text.Contains('-')) // Lose
            {
                grb2.Enabled = false;
                lblLettresRestants.Text = "YOU LOSE ;(";
                btnReset.Focus();
            }
            else if (nbTentative < 10 && !txtWord1.Text.Contains('-')) // Win
            {
                grb2.Enabled = false;
                lblLettresRestants.Text = "You win! =)";
                btnReset.Focus();
            }
        }


        /// <summary>
        /// Methode traitement de la lettre
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool Ft_FindLetter(char c)
        {
            //string tmpWord = word;
            int index;
            bool test = false;
            while (word.IndexOf(c) != -1)
            {
                index = word.IndexOf(c);
                if (index != -1) // Si word contient la lettre
                {
                    // Valeur du test
                    test = true;

                    // Mettre à jour txt: Insertion letter dans txtW puis Supp du char en trop
                    txtWord1.Text = txtWord1.Text.Insert(index, c.ToString());
                    txtWord1.Text = txtWord1.Text.Remove(index + 1, 1);

                    // Mettre à jour word : Insertion '-' dans word puis Supp du char en trop
                    word = word.Insert(index, '-'.ToString());
                    word = word.Remove(index + 1, 1);
                }
            }
            return test;
        }

        /// <summary>
        /// Event btn sub1
        /// if word is correct, Player 2 turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub1_Click(object sender, EventArgs e)
        {
            // Vérifier le format du mot
            bool letterTest = true;

            // Si bon caractères: letterTest = true
            for (int i = 0; i < txtWord1.Text.Length; i++)
            {
                txtWord1.Text = txtWord1.Text.ToUpper();
                if (!(((int)txtWord1.Text[i] >= 65 && (int)txtWord1.Text[i] <= 90)))
                {
                    letterTest = false;
                }
            }

            //Si bonne taille et letterTest = true
            if (txtWord1.Text.Length <= 15 && letterTest)
            {
                // Svgder le mot à trouver
                word = txtWord1.Text;

                // Changer chaque letter par '-'
                txtWord1.Text = "";
                for (int j = 0; j < word.Length; j++)
                {
                    txtWord1.Text += '-';
                }

                // Changement d'accès // de Joueur
                // Player 1
                grb1.Enabled = false;

                // Player 2
                grb2.Enabled = true;
                btnReset.Enabled = true;

            }
            else
            {
                // txtW n'est pas correct : efface la zone
                MessageBox.Show("Le mot ne doit comporter que des lettres alphabétiques (pas d'espace, pas d'accent)");
                txtWord1.Text = "";
                txtWord1.Focus();
            }
        }


        /// <summary>
        /// Event click on reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub3_Click(object sender, EventArgs e)
        {
            // Réactivation des boutons
            for (int index = 0; index < 26; index++)
            {
                grb2.Controls[index].Enabled = true;
            }
            // Recharger le Jeu
            FrmHangman_Load(null, null);
        }


        /// <summary>
        /// event press Enter 
        /// return to btnSub1 event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWord1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSub1_Click(null, null);
            }
        }
    }
}

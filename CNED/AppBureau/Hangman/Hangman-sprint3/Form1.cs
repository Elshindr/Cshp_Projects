using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_sprint1
{
    public partial class FrmHangman : System.Windows.Forms.Form
    {
        // Variables 
        private string word;
        private string endWord;
        private string namePic = "";
        private int nbTentative = 0;

        public FrmHangman()
        {
            InitializeComponent();
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
            RemplirCboLetters();
            grb2.Enabled = false;
            lblLettresRestants.Text = "";
            nbTentative = 0;
            pibPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0");

        }
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
        /// Remplir la ComboBox avec des lettres
        /// </summary>
        private void RemplirCboLetters()
        {
            // Vider la comboBox
            cobLetter2.Items.Clear();
            // Remplir la comboBox avec les lettres
            for (int i = 0; i < 26; i++)
            {
                cobLetter2.Items.Add((char)('A' + i));
            }
            cobLetter2.SelectedIndex = 0;
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
                endWord = txtWord1.Text;
                // Changer chaque letter par '-'
                txtWord1.Text = "";
                for (int j = 0; j < word.Length; j++)
                {
                    txtWord1.Text += '-';
                }

                //Changement d'accès // de Joueur
                // Player 1
                grb1.Enabled = false;

                // Player 2
                grb2.Enabled = true;
                btnReset.Enabled = true;
                cobLetter2.Enabled = true;
                btnSub2.Enabled = true;
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
        /// Event click on submit button 2
        /// Find the char in the word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWord1.Text.Contains('-') && nbTentative < 10)// En cours de Jeu
                {

                    // Si faux: Incrémentation + Change image + Afficher lettre testée sur label
                    if (!Ft_FindLetter((char)cobLetter2.SelectedItem))
                    {
                        nbTentative++;
                        namePic = "pendu" + nbTentative;
                        pibPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject(namePic);
                    }

                    // Ajout lettre sur label. Supprimer lettres testés de combolist.
                    lblLettresRestants.Text += cobLetter2.SelectedItem.ToString();
                    cobLetter2.Items.Remove(cobLetter2.SelectedItem);

                    // Focus sur 1ere lettre restante
                    cobLetter2.SelectedIndex = 0;
                }
                if (nbTentative >= 10 && txtWord1.Text.Contains('-')) // Lose
                {
                    MessageBox.Show("You lose! :(", "End Game");
                    btnSub2.Enabled = false;
                    cobLetter2.Enabled = false;
                    lblLettresRestants.Text = endWord;
                    btnReset.Focus();
                }
                else if (nbTentative < 10 && !txtWord1.Text.Contains('-')) // Win
                {
                    MessageBox.Show("You win! =)", "End Game");
                    lblLettresRestants.Text = endWord;
                    btnSub2.Enabled = false;
                    cobLetter2.Enabled = false;
                    btnReset.Focus();
                }

            }
            catch
            {
                // SI tentative de suppression de lettre alors que combo est vide
                // cpt le mot doit être trouvé avant
                btnSub2.Enabled = false;
                cobLetter2.Enabled = false;
                btnReset.Enabled = true;
            }
        }
        /// <summary>
        /// Event click on reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSub3_Click(object sender, EventArgs e)
        {
            FrmHangman_Load(null, null);
        }

        /// <summary>
        /// Event : whe change a letter in combo
        /// focus is on submit2 btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cobLetter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSub2.Focus();
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

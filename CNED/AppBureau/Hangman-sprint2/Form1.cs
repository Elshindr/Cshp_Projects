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

            // Partie J2
            RemplirCboLetters();
            grb2.Enabled = false;
            lblLettresRestants.Text = "";
        }

        /// <summary>
        /// Remplir la ComboBox avec des lettres
        /// </summary>
        private void RemplirCboLetters()
        {
            //vider la comboBox
            cobLetter2.Items.Clear();
            // remplir la comboBox avec les lettres
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
            bool letterTest = true;
            string wordOrigin = "";
            for (int i = 0; i < txtWord1.Text.Length; i++)
            {
                if (!(((int)txtWord1.Text[i] >= 97 && (int)txtWord1.Text[i] <= 122) || ((int)txtWord1.Text[i] >= 65 && (int)txtWord1.Text[i] <= 90)))
                {
                    letterTest = false;
                }
            }
            if (txtWord1.Text.Length <= 15 && letterTest)
            {
                wordOrigin = txtWord1.Text;
                char[] wordToFind = new char[txtWord1.Text.Length];
                for (int j = 0; j < txtWord1.Text.Length; j++)
                {
                    wordToFind[j] = '-';
                }
                txtWord1.Text = String.Concat(wordToFind);
                // Player 1
                grb1.Enabled = false;

                // Player 2
                grb2.Enabled = true;
            }
            else
            {
                // le mot n'est pas correct : efface la zone
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
                // Affiche la lettre dans le label
                lblLettresRestants.Text += cobLetter2.SelectedItem.ToString();
                // Supprimer les lettres testés de la liste et du label text
                cobLetter2.Items.Remove(cobLetter2.SelectedItem);
                //Focus sur 1ere lettre restante
                cobLetter2.SelectedIndex = 0;
            }
            catch
            {
                // cas d'une tentative de suppression de lettre alors que le combo est vide
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
    }
}

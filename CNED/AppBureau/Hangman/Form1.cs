using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu_AppBureau
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initialisation des objets graphiques
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplir la ComboBox avec des lettres
        /// </summary>
        private void RemplirCboLetters()
        {
            //vider la comboBox
            cbo_letterP2.Items.Clear();
            // remplir la comboBox avec les lettres
            for(int i = 0; i < 26; i++)
            {
                cbo_letterP2.Items.Add((char)('A' + i));
            }
            cbo_letterP2.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Evenement au chargement de la fenetre
        /// création boutons et lettres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            // Partie P1
            string wordOrigin = "";
            txt_wordP1.Text = "";
            txt_wordP1.Focus();

            // Partie J2
            RemplirCboLetters();
            cbo_letterP2.Enabled = false;
            btn_submitP2.Enabled = false;
        }



        private void comBx_letterP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_submitWordP1_Click(object sender, EventArgs e)
        {
            
            
            //if(wordOrigin cbo_letterP2.Items.Contains)

            lbl_lettresrestants.Text = cbo_letterP2.Items.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool letterTest = true;
            string wordOrigin = "";
            for(int i = 0; i < txt_wordP1.Text.Length; i++)
            {
                if ( !(((int)txt_wordP1.Text[i] >= 97 && (int)txt_wordP1.Text[i] <= 122) || ((int)txt_wordP1.Text[i] >= 65 && (int)txt_wordP1.Text[i] <= 90)) ) {
                    letterTest = false;
                }
            }
            if (txt_wordP1.Text.Length <= 15 && letterTest)
            {
                wordOrigin = txt_wordP1.Text;
                char[] wordToFind = new char[txt_wordP1.Text.Length];
                for(int j = 0; j < txt_wordP1.Text.Length; j++)
                {
                    wordToFind[j] = '-';
                }
                txt_wordP1.Text = String.Concat(wordToFind);
                
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Mot non valide", "Erreur");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {

        }
    }
}

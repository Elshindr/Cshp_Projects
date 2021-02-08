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
            RemplirCboLetters();
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

        private void btnSub1_Click(object sender, EventArgs e)
        {

        }

    }
}

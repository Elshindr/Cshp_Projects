using ProjetCned.controleur;
using System;
using System.Windows.Forms;

namespace ProjetCned
{
    /// <summary>
    /// Fenêtre de connexion au programme
    /// </summary>
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;


        /// <summary>
        /// Recupere l'instance du controleur et initialisation des composants de la Frame
        /// </summary>
        /// <param name="controle"></param>
        public FrmConnexion(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }


        /// <summary>
        /// Evénement du click sur connexion, 
        /// vérifie que les valeurs des textbox login et pwd sont correctes
        /// Sinon affiche un message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnconnexion_Click(object sender, EventArgs e)
        {
            if (!txtlogin.Text.Equals("") && !txtpwd.Text.Equals(""))
            {
                if (!controle.Authentification(txtlogin.Text, txtpwd.Text))
                {
                    MessageBox.Show("Mauvais mot de passe ou login", "Erreur Connexion");
                }
            }
            else
            {
                MessageBox.Show("Champs non rempli", "Erreur champs invalide");
            }

        }
    }
}

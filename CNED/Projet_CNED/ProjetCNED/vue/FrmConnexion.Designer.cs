
namespace ProjetCned
{
    partial class FrmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconnexion = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnconnexion
            // 
            this.btnconnexion.Location = new System.Drawing.Point(73, 153);
            this.btnconnexion.Name = "btnconnexion";
            this.btnconnexion.Size = new System.Drawing.Size(161, 35);
            this.btnconnexion.TabIndex = 0;
            this.btnconnexion.Text = "Se connecter";
            this.btnconnexion.UseVisualStyleBackColor = true;
            this.btnconnexion.Click += new System.EventHandler(this.btnconnexion_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(52, 55);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(38, 17);
            this.lbllogin.TabIndex = 1;
            this.lbllogin.Text = "login";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(55, 103);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(93, 17);
            this.lblpwd.TabIndex = 2;
            this.lblpwd.Text = "mot de passe";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(164, 55);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(141, 22);
            this.txtlogin.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(164, 97);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(141, 22);
            this.txtpwd.TabIndex = 4;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 211);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnconnexion);
            this.Name = "FrmConnexion";
            this.Text = "connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconnexion;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpwd;
    }
}


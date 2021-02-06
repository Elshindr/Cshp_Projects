namespace JeuDuPendu
{
    partial class Form1
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.grpTestLettres = new System.Windows.Forms.GroupBox();
            this.lblLettres = new System.Windows.Forms.Label();
            this.cboLettre = new System.Windows.Forms.ComboBox();
            this.btnSubm2 = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.btnSubm1 = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grpTestLettres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.btnSubm1);
            this.grb1.Controls.Add(this.txtMot);
            this.grb1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(384, 79);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Player 1";
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(6, 24);
            this.txtMot.MaxLength = 15;
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(226, 35);
            this.txtMot.TabIndex = 0;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(12, 230);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 31);
            this.lblResultat.TabIndex = 4;
            // 
            // grpTestLettres
            // 
            this.grpTestLettres.Controls.Add(this.lblLettres);
            this.grpTestLettres.Controls.Add(this.btnSubm2);
            this.grpTestLettres.Controls.Add(this.btnRejouer);
            this.grpTestLettres.Controls.Add(this.cboLettre);
            this.grpTestLettres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTestLettres.Location = new System.Drawing.Point(12, 97);
            this.grpTestLettres.Name = "grpTestLettres";
            this.grpTestLettres.Size = new System.Drawing.Size(384, 164);
            this.grpTestLettres.TabIndex = 3;
            this.grpTestLettres.TabStop = false;
            this.grpTestLettres.Text = "Player 2";
            // 
            // lblLettres
            // 
            this.lblLettres.AutoSize = true;
            this.lblLettres.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettres.Location = new System.Drawing.Point(6, 63);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(374, 24);
            this.lblLettres.TabIndex = 2;
            this.lblLettres.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // cboLettre
            // 
            this.cboLettre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLettre.FormattingEnabled = true;
            this.cboLettre.Location = new System.Drawing.Point(6, 19);
            this.cboLettre.Name = "cboLettre";
            this.cboLettre.Size = new System.Drawing.Size(54, 32);
            this.cboLettre.TabIndex = 0;
            // 
            // btnSubm2
            // 
            this.btnSubm2.Image = global::JeuDuPendu.Properties.Resources.icons8_button_48;
            this.btnSubm2.Location = new System.Drawing.Point(96, 19);
            this.btnSubm2.Name = "btnSubm2";
            this.btnSubm2.Size = new System.Drawing.Size(75, 30);
            this.btnSubm2.TabIndex = 1;
            this.btnSubm2.UseVisualStyleBackColor = true;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(332, 112);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(46, 46);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = true;
            // 
            // imgPendu
            // 
            this.imgPendu.Image = global::JeuDuPendu.Properties.Resources.pendu0;
            this.imgPendu.InitialImage = global::JeuDuPendu.Properties.Resources.pendu0;
            this.imgPendu.Location = new System.Drawing.Point(421, 12);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(250, 250);
            this.imgPendu.TabIndex = 1;
            this.imgPendu.TabStop = false;
            // 
            // btnSubm1
            // 
            this.btnSubm1.Image = global::JeuDuPendu.Properties.Resources.icons8_button_48;
            this.btnSubm1.Location = new System.Drawing.Point(260, 25);
            this.btnSubm1.Name = "btnSubm1";
            this.btnSubm1.Size = new System.Drawing.Size(75, 35);
            this.btnSubm1.TabIndex = 1;
            this.btnSubm1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 271);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.grpTestLettres);
            this.Controls.Add(this.imgPendu);
            this.Controls.Add(this.grb1);
            this.Name = "Form1";
            this.Text = "Captain Hangman";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grpTestLettres.ResumeLayout(false);
            this.grpTestLettres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox grpTestLettres;
        private System.Windows.Forms.Label lblLettres;
        private System.Windows.Forms.Button btnSubm2;
        private System.Windows.Forms.ComboBox cboLettre;
        private System.Windows.Forms.Button btnSubm1;
    }
}


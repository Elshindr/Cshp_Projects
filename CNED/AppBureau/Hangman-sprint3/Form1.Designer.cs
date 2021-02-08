
namespace Hangman_sprint1
{
    partial class FrmHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHangman));
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pibPendu = new System.Windows.Forms.PictureBox();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.cobLetter2 = new System.Windows.Forms.ComboBox();
            this.lblLettresRestants = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibPendu)).BeginInit();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSub1
            // 
            this.btnSub1.Image = global::Hangman_sprint1.Properties.Resources.icons8_button_48;
            this.btnSub1.Location = new System.Drawing.Point(314, 27);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(57, 33);
            this.btnSub1.TabIndex = 0;
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Image = global::Hangman_sprint1.Properties.Resources.icons8_button_48;
            this.btnSub2.Location = new System.Drawing.Point(159, 29);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(60, 31);
            this.btnSub2.TabIndex = 1;
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Hangman_sprint1.Properties.Resources.playagain;
            this.btnReset.Location = new System.Drawing.Point(334, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 52);
            this.btnReset.TabIndex = 2;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnSub3_Click);
            // 
            // pibPendu
            // 
            this.pibPendu.Image = ((System.Drawing.Image)(resources.GetObject("pibPendu.Image")));
            this.pibPendu.InitialImage = global::Hangman_sprint1.Properties.Resources.pendu0;
            this.pibPendu.Location = new System.Drawing.Point(423, 12);
            this.pibPendu.Name = "pibPendu";
            this.pibPendu.Size = new System.Drawing.Size(250, 250);
            this.pibPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pibPendu.TabIndex = 3;
            this.pibPendu.TabStop = false;
            // 
            // txtWord1
            // 
            this.txtWord1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord1.Location = new System.Drawing.Point(6, 29);
            this.txtWord1.MaxLength = 15;
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(213, 29);
            this.txtWord1.TabIndex = 4;
            this.txtWord1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord1_KeyPress);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txtWord1);
            this.grb1.Controls.Add(this.btnSub1);
            this.grb1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(390, 76);
            this.grb1.TabIndex = 5;
            this.grb1.TabStop = false;
            this.grb1.Text = "Player 1";
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.cobLetter2);
            this.grb2.Controls.Add(this.lblLettresRestants);
            this.grb2.Controls.Add(this.btnSub2);
            this.grb2.Controls.Add(this.btnReset);
            this.grb2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb2.Location = new System.Drawing.Point(12, 108);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(390, 154);
            this.grb2.TabIndex = 6;
            this.grb2.TabStop = false;
            this.grb2.Text = "Player 2";
            // 
            // cobLetter2
            // 
            this.cobLetter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobLetter2.FormattingEnabled = true;
            this.cobLetter2.Location = new System.Drawing.Point(6, 29);
            this.cobLetter2.Name = "cobLetter2";
            this.cobLetter2.Size = new System.Drawing.Size(121, 32);
            this.cobLetter2.TabIndex = 4;
            this.cobLetter2.SelectedIndexChanged += new System.EventHandler(this.cobLetter2_SelectedIndexChanged);
            // 
            // lblLettresRestants
            // 
            this.lblLettresRestants.AutoSize = true;
            this.lblLettresRestants.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettresRestants.Location = new System.Drawing.Point(10, 71);
            this.lblLettresRestants.Name = "lblLettresRestants";
            this.lblLettresRestants.Size = new System.Drawing.Size(0, 22);
            this.lblLettresRestants.TabIndex = 3;
            // 
            // FrmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 272);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.pibPendu);
            this.Name = "FrmHangman";
            this.Text = "Captain Hangman";
            this.Load += new System.EventHandler(this.FrmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibPendu)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pibPendu;
        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.ComboBox cobLetter2;
        private System.Windows.Forms.Label lblLettresRestants;
    }
}


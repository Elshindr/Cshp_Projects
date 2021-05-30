
namespace Habilitations.vue
{
    partial class FrmHabilitations
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
            this.dataGridDev = new System.Windows.Forms.DataGridView();
            this.grpBoxDev = new System.Windows.Forms.GroupBox();
            this.btnchangerpwd = new System.Windows.Forms.Button();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.cobProfil = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChangerpwd = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPwd = new System.Windows.Forms.Button();
            this.btnEnregistrerPwd = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEncore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDev)).BeginInit();
            this.grpBoxDev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpChangerpwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDev
            // 
            this.dataGridDev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDev.Location = new System.Drawing.Point(6, 21);
            this.dataGridDev.Name = "dataGridDev";
            this.dataGridDev.RowHeadersWidth = 51;
            this.dataGridDev.RowTemplate.Height = 24;
            this.dataGridDev.Size = new System.Drawing.Size(752, 241);
            this.dataGridDev.TabIndex = 0;
            // 
            // grpBoxDev
            // 
            this.grpBoxDev.Controls.Add(this.btnchangerpwd);
            this.grpBoxDev.Controls.Add(this.dataGridDev);
            this.grpBoxDev.Controls.Add(this.btnsuppr);
            this.grpBoxDev.Controls.Add(this.btnmodifier);
            this.grpBoxDev.Location = new System.Drawing.Point(12, 6);
            this.grpBoxDev.Name = "grpBoxDev";
            this.grpBoxDev.Size = new System.Drawing.Size(764, 298);
            this.grpBoxDev.TabIndex = 1;
            this.grpBoxDev.TabStop = false;
            this.grpBoxDev.Text = "les développeurs";
            // 
            // btnchangerpwd
            // 
            this.btnchangerpwd.Location = new System.Drawing.Point(238, 268);
            this.btnchangerpwd.Name = "btnchangerpwd";
            this.btnchangerpwd.Size = new System.Drawing.Size(123, 23);
            this.btnchangerpwd.TabIndex = 4;
            this.btnchangerpwd.Text = "changer pwd";
            this.btnchangerpwd.UseVisualStyleBackColor = true;
            // 
            // btnsuppr
            // 
            this.btnsuppr.Location = new System.Drawing.Point(121, 268);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(86, 23);
            this.btnsuppr.TabIndex = 3;
            this.btnsuppr.Text = "supprimer";
            this.btnsuppr.UseVisualStyleBackColor = true;
            this.btnsuppr.Click += new System.EventHandler(this.btnsuppr_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(6, 268);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 2;
            this.btnmodifier.Text = "modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.btnannuler);
            this.groupBox1.Controls.Add(this.cobProfil);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtprenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ajouter développeur";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(10, 126);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(88, 23);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(132, 126);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(75, 23);
            this.btnannuler.TabIndex = 10;
            this.btnannuler.Text = "annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            // 
            // cobProfil
            // 
            this.cobProfil.FormattingEnabled = true;
            this.cobProfil.Location = new System.Drawing.Point(368, 113);
            this.cobProfil.Name = "cobProfil";
            this.cobProfil.Size = new System.Drawing.Size(172, 24);
            this.cobProfil.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(368, 79);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(172, 22);
            this.txtTel.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(368, 38);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(247, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(68, 79);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(204, 22);
            this.txtprenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(68, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(204, 22);
            this.txtNom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "profil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // grpChangerpwd
            // 
            this.grpChangerpwd.Controls.Add(this.btnAnnulerPwd);
            this.grpChangerpwd.Controls.Add(this.btnEnregistrerPwd);
            this.grpChangerpwd.Controls.Add(this.txtPwd);
            this.grpChangerpwd.Controls.Add(this.txtEncore);
            this.grpChangerpwd.Controls.Add(this.label7);
            this.grpChangerpwd.Controls.Add(this.label6);
            this.grpChangerpwd.Location = new System.Drawing.Point(12, 472);
            this.grpChangerpwd.Name = "grpChangerpwd";
            this.grpChangerpwd.Size = new System.Drawing.Size(764, 100);
            this.grpChangerpwd.TabIndex = 3;
            this.grpChangerpwd.TabStop = false;
            this.grpChangerpwd.Text = "changer mot de passe";
            // 
            // btnAnnulerPwd
            // 
            this.btnAnnulerPwd.Location = new System.Drawing.Point(132, 71);
            this.btnAnnulerPwd.Name = "btnAnnulerPwd";
            this.btnAnnulerPwd.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerPwd.TabIndex = 5;
            this.btnAnnulerPwd.Text = "annuler";
            this.btnAnnulerPwd.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerPwd
            // 
            this.btnEnregistrerPwd.Location = new System.Drawing.Point(10, 71);
            this.btnEnregistrerPwd.Name = "btnEnregistrerPwd";
            this.btnEnregistrerPwd.Size = new System.Drawing.Size(88, 23);
            this.btnEnregistrerPwd.TabIndex = 4;
            this.btnEnregistrerPwd.Text = "enregistrer";
            this.btnEnregistrerPwd.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(63, 38);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 3;
            // 
            // txtEncore
            // 
            this.txtEncore.Location = new System.Drawing.Point(404, 39);
            this.txtEncore.Name = "txtEncore";
            this.txtEncore.Size = new System.Drawing.Size(100, 22);
            this.txtEncore.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "encore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "pwd";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 601);
            this.Controls.Add(this.grpChangerpwd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxDev);
            this.Name = "FrmHabilitations";
            this.Text = "habilitations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDev)).EndInit();
            this.grpBoxDev.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpChangerpwd.ResumeLayout(false);
            this.grpChangerpwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDev;
        private System.Windows.Forms.GroupBox grpBoxDev;
        private System.Windows.Forms.Button btnchangerpwd;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobProfil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.GroupBox grpChangerpwd;
        private System.Windows.Forms.Button btnAnnulerPwd;
        private System.Windows.Forms.Button btnEnregistrerPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtEncore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}


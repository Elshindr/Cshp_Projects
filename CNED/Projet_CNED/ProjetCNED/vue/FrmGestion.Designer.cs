
namespace ProjetCned.vue
{
    partial class FrmGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpGestionPers = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPers = new System.Windows.Forms.Button();
            this.btnEnregistrerPers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cobservice = new System.Windows.Forms.ComboBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouterPers = new System.Windows.Forms.Button();
            this.dataPersonnel = new System.Windows.Forms.DataGridView();
            this.projetcnedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetcnedDataSet = new ProjetCned.projetcnedDataSet();
            this.grpListePersonnel = new System.Windows.Forms.GroupBox();
            this.btnGestionAbs = new System.Windows.Forms.Button();
            this.btnSupprPers = new System.Windows.Forms.Button();
            this.btnModifierPers = new System.Windows.Forms.Button();
            this.grpabsence = new System.Windows.Forms.GroupBox();
            this.grpGestionAbs = new System.Windows.Forms.GroupBox();
            this.btnAnnulerAbs = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnregistrerAbs = new System.Windows.Forms.Button();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cobMotif = new System.Windows.Forms.ComboBox();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnSupprAbs = new System.Windows.Forms.Button();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.dataAbsence = new System.Windows.Forms.DataGridView();
            this.grpGestionPers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetcnedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetcnedDataSet)).BeginInit();
            this.grpListePersonnel.SuspendLayout();
            this.grpabsence.SuspendLayout();
            this.grpGestionAbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGestionPers
            // 
            this.grpGestionPers.Controls.Add(this.btnAnnulerPers);
            this.grpGestionPers.Controls.Add(this.btnEnregistrerPers);
            this.grpGestionPers.Controls.Add(this.label5);
            this.grpGestionPers.Controls.Add(this.cobservice);
            this.grpGestionPers.Controls.Add(this.txtmail);
            this.grpGestionPers.Controls.Add(this.txttel);
            this.grpGestionPers.Controls.Add(this.txtprenom);
            this.grpGestionPers.Controls.Add(this.label4);
            this.grpGestionPers.Controls.Add(this.label3);
            this.grpGestionPers.Controls.Add(this.label2);
            this.grpGestionPers.Controls.Add(this.txtnom);
            this.grpGestionPers.Controls.Add(this.label1);
            this.grpGestionPers.Location = new System.Drawing.Point(21, 313);
            this.grpGestionPers.Name = "grpGestionPers";
            this.grpGestionPers.Size = new System.Drawing.Size(758, 115);
            this.grpGestionPers.TabIndex = 0;
            this.grpGestionPers.TabStop = false;
            this.grpGestionPers.Text = "Gestion personnels";
            // 
            // btnAnnulerPers
            // 
            this.btnAnnulerPers.Location = new System.Drawing.Point(633, 70);
            this.btnAnnulerPers.Name = "btnAnnulerPers";
            this.btnAnnulerPers.Size = new System.Drawing.Size(125, 40);
            this.btnAnnulerPers.TabIndex = 11;
            this.btnAnnulerPers.Text = "annuler";
            this.btnAnnulerPers.UseVisualStyleBackColor = true;
            this.btnAnnulerPers.Click += new System.EventHandler(this.btnAnnulerPers_Click);
            // 
            // btnEnregistrerPers
            // 
            this.btnEnregistrerPers.Location = new System.Drawing.Point(502, 69);
            this.btnEnregistrerPers.Name = "btnEnregistrerPers";
            this.btnEnregistrerPers.Size = new System.Drawing.Size(125, 40);
            this.btnEnregistrerPers.TabIndex = 10;
            this.btnEnregistrerPers.Text = "enregistrer";
            this.btnEnregistrerPers.UseVisualStyleBackColor = true;
            this.btnEnregistrerPers.Click += new System.EventHandler(this.btnEnregistrerPers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "service";
            // 
            // cobservice
            // 
            this.cobservice.FormattingEnabled = true;
            this.cobservice.Location = new System.Drawing.Point(539, 24);
            this.cobservice.Name = "cobservice";
            this.cobservice.Size = new System.Drawing.Size(150, 24);
            this.cobservice.TabIndex = 8;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(271, 60);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(134, 22);
            this.txtmail.TabIndex = 7;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(271, 31);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(134, 22);
            this.txttel.TabIndex = 6;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(63, 65);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(127, 22);
            this.txtprenom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(63, 30);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(127, 22);
            this.txtnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // btnAjouterPers
            // 
            this.btnAjouterPers.Location = new System.Drawing.Point(21, 269);
            this.btnAjouterPers.Name = "btnAjouterPers";
            this.btnAjouterPers.Size = new System.Drawing.Size(125, 40);
            this.btnAjouterPers.TabIndex = 1;
            this.btnAjouterPers.Text = "ajouter";
            this.btnAjouterPers.UseVisualStyleBackColor = true;
            this.btnAjouterPers.Click += new System.EventHandler(this.btnAjouterPers_Click);
            // 
            // dataPersonnel
            // 
            this.dataPersonnel.AllowUserToAddRows = false;
            this.dataPersonnel.AllowUserToDeleteRows = false;
            this.dataPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonnel.Location = new System.Drawing.Point(18, 31);
            this.dataPersonnel.Name = "dataPersonnel";
            this.dataPersonnel.ReadOnly = true;
            this.dataPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataPersonnel.RowTemplate.Height = 24;
            this.dataPersonnel.Size = new System.Drawing.Size(761, 226);
            this.dataPersonnel.TabIndex = 0;
            // 
            // projetcnedDataSetBindingSource
            // 
            this.projetcnedDataSetBindingSource.DataSource = this.projetcnedDataSet;
            this.projetcnedDataSetBindingSource.Position = 0;
            // 
            // projetcnedDataSet
            // 
            this.projetcnedDataSet.DataSetName = "projetcnedDataSet";
            this.projetcnedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpListePersonnel
            // 
            this.grpListePersonnel.Controls.Add(this.btnGestionAbs);
            this.grpListePersonnel.Controls.Add(this.btnSupprPers);
            this.grpListePersonnel.Controls.Add(this.btnModifierPers);
            this.grpListePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListePersonnel.Location = new System.Drawing.Point(12, 13);
            this.grpListePersonnel.Name = "grpListePersonnel";
            this.grpListePersonnel.Size = new System.Drawing.Size(775, 435);
            this.grpListePersonnel.TabIndex = 3;
            this.grpListePersonnel.TabStop = false;
            this.grpListePersonnel.Text = "Liste Personnels";
            // 
            // btnGestionAbs
            // 
            this.btnGestionAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAbs.Location = new System.Drawing.Point(642, 257);
            this.btnGestionAbs.Name = "btnGestionAbs";
            this.btnGestionAbs.Size = new System.Drawing.Size(125, 40);
            this.btnGestionAbs.TabIndex = 7;
            this.btnGestionAbs.Text = "gérer absences";
            this.btnGestionAbs.UseVisualStyleBackColor = true;
            this.btnGestionAbs.Click += new System.EventHandler(this.btnGestionAbs_Click);
            // 
            // btnSupprPers
            // 
            this.btnSupprPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprPers.Location = new System.Drawing.Point(140, 257);
            this.btnSupprPers.Name = "btnSupprPers";
            this.btnSupprPers.Size = new System.Drawing.Size(125, 40);
            this.btnSupprPers.TabIndex = 4;
            this.btnSupprPers.Text = "supprimer";
            this.btnSupprPers.UseVisualStyleBackColor = true;
            this.btnSupprPers.Click += new System.EventHandler(this.btnSupprPers_Click);
            // 
            // btnModifierPers
            // 
            this.btnModifierPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierPers.Location = new System.Drawing.Point(271, 256);
            this.btnModifierPers.Name = "btnModifierPers";
            this.btnModifierPers.Size = new System.Drawing.Size(125, 40);
            this.btnModifierPers.TabIndex = 5;
            this.btnModifierPers.Text = "modifier";
            this.btnModifierPers.UseVisualStyleBackColor = true;
            this.btnModifierPers.Click += new System.EventHandler(this.btnModifierPers_Click);
            // 
            // grpabsence
            // 
            this.grpabsence.Controls.Add(this.grpGestionAbs);
            this.grpabsence.Controls.Add(this.btnModifierAbs);
            this.grpabsence.Controls.Add(this.btnSupprAbs);
            this.grpabsence.Controls.Add(this.btnAjouterAbs);
            this.grpabsence.Controls.Add(this.dataAbsence);
            this.grpabsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpabsence.Location = new System.Drawing.Point(13, 455);
            this.grpabsence.Name = "grpabsence";
            this.grpabsence.Size = new System.Drawing.Size(775, 377);
            this.grpabsence.TabIndex = 6;
            this.grpabsence.TabStop = false;
            this.grpabsence.Text = "Liste Absences";
            // 
            // grpGestionAbs
            // 
            this.grpGestionAbs.Controls.Add(this.btnAnnulerAbs);
            this.grpGestionAbs.Controls.Add(this.label8);
            this.grpGestionAbs.Controls.Add(this.btnEnregistrerAbs);
            this.grpGestionAbs.Controls.Add(this.dateFin);
            this.grpGestionAbs.Controls.Add(this.label6);
            this.grpGestionAbs.Controls.Add(this.dateDebut);
            this.grpGestionAbs.Controls.Add(this.label7);
            this.grpGestionAbs.Controls.Add(this.cobMotif);
            this.grpGestionAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGestionAbs.Location = new System.Drawing.Point(8, 215);
            this.grpGestionAbs.Name = "grpGestionAbs";
            this.grpGestionAbs.Size = new System.Drawing.Size(758, 146);
            this.grpGestionAbs.TabIndex = 11;
            this.grpGestionAbs.TabStop = false;
            this.grpGestionAbs.Text = "Gestion Absences";
            // 
            // btnAnnulerAbs
            // 
            this.btnAnnulerAbs.Location = new System.Drawing.Point(627, 90);
            this.btnAnnulerAbs.Name = "btnAnnulerAbs";
            this.btnAnnulerAbs.Size = new System.Drawing.Size(125, 40);
            this.btnAnnulerAbs.TabIndex = 8;
            this.btnAnnulerAbs.Text = "annuler";
            this.btnAnnulerAbs.UseVisualStyleBackColor = true;
            this.btnAnnulerAbs.Click += new System.EventHandler(this.btnAnnulerAbs_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "fin";
            // 
            // btnEnregistrerAbs
            // 
            this.btnEnregistrerAbs.Location = new System.Drawing.Point(490, 90);
            this.btnEnregistrerAbs.Name = "btnEnregistrerAbs";
            this.btnEnregistrerAbs.Size = new System.Drawing.Size(125, 40);
            this.btnEnregistrerAbs.TabIndex = 7;
            this.btnEnregistrerAbs.Text = "enregistrer";
            this.btnEnregistrerAbs.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbs.Click += new System.EventHandler(this.btnEnregistrerAbs_Click);
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(65, 85);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(240, 22);
            this.dateFin.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "debut";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(65, 47);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(240, 22);
            this.dateDebut.TabIndex = 1;
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "motif";
            // 
            // cobMotif
            // 
            this.cobMotif.FormattingEnabled = true;
            this.cobMotif.Location = new System.Drawing.Point(402, 47);
            this.cobMotif.Name = "cobMotif";
            this.cobMotif.Size = new System.Drawing.Size(181, 24);
            this.cobMotif.TabIndex = 3;
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbs.Location = new System.Drawing.Point(635, 153);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(125, 40);
            this.btnModifierAbs.TabIndex = 10;
            this.btnModifierAbs.Text = "modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = true;
            this.btnModifierAbs.Click += new System.EventHandler(this.btnModifierAbs_Click);
            // 
            // btnSupprAbs
            // 
            this.btnSupprAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprAbs.Location = new System.Drawing.Point(635, 92);
            this.btnSupprAbs.Name = "btnSupprAbs";
            this.btnSupprAbs.Size = new System.Drawing.Size(125, 40);
            this.btnSupprAbs.TabIndex = 9;
            this.btnSupprAbs.Text = "supprimer";
            this.btnSupprAbs.UseVisualStyleBackColor = true;
            this.btnSupprAbs.Click += new System.EventHandler(this.btnSupprAbs_Click);
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAbs.Location = new System.Drawing.Point(635, 21);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(125, 40);
            this.btnAjouterAbs.TabIndex = 8;
            this.btnAjouterAbs.Text = "ajouter";
            this.btnAjouterAbs.UseVisualStyleBackColor = true;
            this.btnAjouterAbs.Click += new System.EventHandler(this.btnAjouterAbs_Click);
            // 
            // dataAbsence
            // 
            this.dataAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAbsence.Location = new System.Drawing.Point(8, 21);
            this.dataAbsence.Name = "dataAbsence";
            this.dataAbsence.RowHeadersWidth = 51;
            this.dataAbsence.RowTemplate.Height = 24;
            this.dataAbsence.Size = new System.Drawing.Size(493, 172);
            this.dataAbsence.TabIndex = 0;
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 864);
            this.Controls.Add(this.grpabsence);
            this.Controls.Add(this.dataPersonnel);
            this.Controls.Add(this.btnAjouterPers);
            this.Controls.Add(this.grpGestionPers);
            this.Controls.Add(this.grpListePersonnel);
            this.Name = "FrmGestion";
            this.Text = "Gestionnaire de personnels";
            this.grpGestionPers.ResumeLayout(false);
            this.grpGestionPers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetcnedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetcnedDataSet)).EndInit();
            this.grpListePersonnel.ResumeLayout(false);
            this.grpabsence.ResumeLayout(false);
            this.grpGestionAbs.ResumeLayout(false);
            this.grpGestionAbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestionPers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobservice;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouterPers;
        private System.Windows.Forms.Button btnAnnulerPers;
        private System.Windows.Forms.Button btnEnregistrerPers;
        private System.Windows.Forms.DataGridView dataPersonnel;
        private System.Windows.Forms.BindingSource projetcnedDataSetBindingSource;
        private projetcnedDataSet projetcnedDataSet;
        private System.Windows.Forms.GroupBox grpListePersonnel;
        private System.Windows.Forms.Button btnSupprPers;
        private System.Windows.Forms.Button btnModifierPers;
        private System.Windows.Forms.GroupBox grpabsence;
        private System.Windows.Forms.DataGridView dataAbsence;
        private System.Windows.Forms.Button btnGestionAbs;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cobMotif;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Button btnEnregistrerAbs;
        private System.Windows.Forms.Button btnAnnulerAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnSupprAbs;
        private System.Windows.Forms.GroupBox grpGestionAbs;
    }
}
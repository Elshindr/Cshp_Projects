
namespace Pendu_AppBureau
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
            this.txt_wordP1 = new System.Windows.Forms.TextBox();
            this.cbo_letterP2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_submitP1 = new System.Windows.Forms.Button();
            this.btn_submitP2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_lettresrestants = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.ibo_Hangman = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibo_Hangman)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_wordP1
            // 
            this.txt_wordP1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wordP1.Location = new System.Drawing.Point(6, 19);
            this.txt_wordP1.Name = "txt_wordP1";
            this.txt_wordP1.Size = new System.Drawing.Size(211, 30);
            this.txt_wordP1.TabIndex = 6;
            // 
            // cbo_letterP2
            // 
            this.cbo_letterP2.FormattingEnabled = true;
            this.cbo_letterP2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbo_letterP2.Location = new System.Drawing.Point(6, 21);
            this.cbo_letterP2.Name = "cbo_letterP2";
            this.cbo_letterP2.Size = new System.Drawing.Size(121, 24);
            this.cbo_letterP2.TabIndex = 7;
            this.cbo_letterP2.SelectedIndexChanged += new System.EventHandler(this.comBx_letterP2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_submitP1);
            this.groupBox1.Controls.Add(this.txt_wordP1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // btn_submitP1
            // 
            this.btn_submitP1.Image = global::Pendu_AppBureau.Properties.Resources.icons8_button_48;
            this.btn_submitP1.Location = new System.Drawing.Point(240, 19);
            this.btn_submitP1.Name = "btn_submitP1";
            this.btn_submitP1.Size = new System.Drawing.Size(57, 32);
            this.btn_submitP1.TabIndex = 9;
            this.btn_submitP1.UseVisualStyleBackColor = true;
            this.btn_submitP1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_submitP2
            // 
            this.btn_submitP2.Image = global::Pendu_AppBureau.Properties.Resources.icons8_button_48;
            this.btn_submitP2.Location = new System.Drawing.Point(240, 16);
            this.btn_submitP2.Name = "btn_submitP2";
            this.btn_submitP2.Size = new System.Drawing.Size(57, 32);
            this.btn_submitP2.TabIndex = 0;
            this.btn_submitP2.UseVisualStyleBackColor = true;
            this.btn_submitP2.Click += new System.EventHandler(this.btn_submitWordP1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_submitP2);
            this.groupBox2.Controls.Add(this.lbl_lettresrestants);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_quit);
            this.groupBox2.Controls.Add(this.cbo_letterP2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 154);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // lbl_lettresrestants
            // 
            this.lbl_lettresrestants.AutoSize = true;
            this.lbl_lettresrestants.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lettresrestants.Location = new System.Drawing.Point(5, 67);
            this.lbl_lettresrestants.Name = "lbl_lettresrestants";
            this.lbl_lettresrestants.Size = new System.Drawing.Size(356, 23);
            this.lbl_lettresrestants.TabIndex = 8;
            this.lbl_lettresrestants.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // btn_reset
            // 
            this.btn_reset.Image = global::Pendu_AppBureau.Properties.Resources.icons8_available_updates_48;
            this.btn_reset.Location = new System.Drawing.Point(6, 104);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(55, 48);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::Pendu_AppBureau.Properties.Resources.icons8_export_48;
            this.btn_quit.Location = new System.Drawing.Point(313, 100);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(46, 48);
            this.btn_quit.TabIndex = 8;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // ibo_Hangman
            // 
            this.ibo_Hangman.ErrorImage = global::Pendu_AppBureau.Properties.Resources.pendu0;
            this.ibo_Hangman.Image = global::Pendu_AppBureau.Properties.Resources.pendu0;
            this.ibo_Hangman.InitialImage = global::Pendu_AppBureau.Properties.Resources.pendu0;
            this.ibo_Hangman.Location = new System.Drawing.Point(383, 12);
            this.ibo_Hangman.Name = "ibo_Hangman";
            this.ibo_Hangman.Size = new System.Drawing.Size(250, 250);
            this.ibo_Hangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibo_Hangman.TabIndex = 3;
            this.ibo_Hangman.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ibo_Hangman);
            this.Name = "Form1";
            this.Text = "Captain Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibo_Hangman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_submitP2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox ibo_Hangman;
        private System.Windows.Forms.TextBox txt_wordP1;
        private System.Windows.Forms.ComboBox cbo_letterP2;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_lettresrestants;
        private System.Windows.Forms.Button btn_submitP1;
    }
}


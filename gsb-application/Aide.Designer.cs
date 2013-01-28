using System.Windows.Forms;
namespace gsb_application
{
    partial class Aide
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
            System.Windows.Forms.RichTextBox richTextBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aide));
            System.Windows.Forms.RichTextBox richTextBox2;
            System.Windows.Forms.RichTextBox richTextBox3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageConnexion = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSaisiePret = new System.Windows.Forms.TabPage();
            this.pageConsultationPret = new System.Windows.Forms.TabPage();
            this.pageCreerUtilisateur = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pageStat = new System.Windows.Forms.TabPage();
            this.pageProfil = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.pageConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pageCreerUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pageProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Location = new System.Drawing.Point(6, 215);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(594, 96);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox2.Location = new System.Drawing.Point(6, 215);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(609, 47);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = System.Drawing.SystemColors.Window;
            richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox3.Location = new System.Drawing.Point(3, 251);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new System.Drawing.Size(609, 47);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.pageConnexion);
            this.tabControl1.Controls.Add(this.pageSaisiePret);
            this.tabControl1.Controls.Add(this.pageConsultationPret);
            this.tabControl1.Controls.Add(this.pageCreerUtilisateur);
            this.tabControl1.Controls.Add(this.pageStat);
            this.tabControl1.Controls.Add(this.pageProfil);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // pageConnexion
            // 
            this.pageConnexion.AutoScroll = true;
            this.pageConnexion.Controls.Add(this.label3);
            this.pageConnexion.Controls.Add(this.pictureBox3);
            this.pageConnexion.Controls.Add(this.label2);
            this.pageConnexion.Controls.Add(this.pictureBox2);
            this.pageConnexion.Controls.Add(richTextBox1);
            this.pageConnexion.Controls.Add(this.label1);
            this.pageConnexion.Controls.Add(this.pictureBox1);
            this.pageConnexion.Location = new System.Drawing.Point(4, 22);
            this.pageConnexion.Name = "pageConnexion";
            this.pageConnexion.Padding = new System.Windows.Forms.Padding(3);
            this.pageConnexion.Size = new System.Drawing.Size(625, 324);
            this.pageConnexion.TabIndex = 0;
            this.pageConnexion.Text = "Connexion";
            this.pageConnexion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "menu de l\'application lorsqu\'un utilisateur est connecté";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::gsb_application.Properties.Resources.menu_co;
            this.pictureBox3.Location = new System.Drawing.Point(78, 371);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(448, 25);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "menu de l\'application lorsque l\'utilisateur n\'est pas connecté";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::gsb_application.Properties.Resources.menu_deco;
            this.pictureBox2.Location = new System.Drawing.Point(105, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 25);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "fenêtre de connexion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::gsb_application.Properties.Resources.connexion1;
            this.pictureBox1.Location = new System.Drawing.Point(213, 6);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(179, 179);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(179, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pageSaisiePret
            // 
            this.pageSaisiePret.Location = new System.Drawing.Point(4, 22);
            this.pageSaisiePret.Name = "pageSaisiePret";
            this.pageSaisiePret.Padding = new System.Windows.Forms.Padding(3);
            this.pageSaisiePret.Size = new System.Drawing.Size(625, 324);
            this.pageSaisiePret.TabIndex = 1;
            this.pageSaisiePret.Text = "Saisie d\'un prêt";
            this.pageSaisiePret.UseVisualStyleBackColor = true;
            // 
            // pageConsultationPret
            // 
            this.pageConsultationPret.Location = new System.Drawing.Point(4, 22);
            this.pageConsultationPret.Name = "pageConsultationPret";
            this.pageConsultationPret.Padding = new System.Windows.Forms.Padding(3);
            this.pageConsultationPret.Size = new System.Drawing.Size(625, 324);
            this.pageConsultationPret.TabIndex = 2;
            this.pageConsultationPret.Text = "Consultation des prêts";
            this.pageConsultationPret.UseVisualStyleBackColor = true;
            // 
            // pageCreerUtilisateur
            // 
            this.pageCreerUtilisateur.Controls.Add(richTextBox3);
            this.pageCreerUtilisateur.Controls.Add(this.label6);
            this.pageCreerUtilisateur.Controls.Add(this.label5);
            this.pageCreerUtilisateur.Controls.Add(this.pictureBox6);
            this.pageCreerUtilisateur.Controls.Add(this.pictureBox5);
            this.pageCreerUtilisateur.Location = new System.Drawing.Point(4, 22);
            this.pageCreerUtilisateur.Name = "pageCreerUtilisateur";
            this.pageCreerUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.pageCreerUtilisateur.Size = new System.Drawing.Size(625, 324);
            this.pageCreerUtilisateur.TabIndex = 3;
            this.pageCreerUtilisateur.Text = "Créer un utilisateur";
            this.pageCreerUtilisateur.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "créer un nouvel administrateur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "créer un nouvel employé";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::gsb_application.Properties.Resources.new_admin;
            this.pictureBox6.Location = new System.Drawing.Point(339, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 217);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::gsb_application.Properties.Resources.new_employe;
            this.pictureBox5.Location = new System.Drawing.Point(85, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 217);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pageStat
            // 
            this.pageStat.Location = new System.Drawing.Point(4, 22);
            this.pageStat.Name = "pageStat";
            this.pageStat.Padding = new System.Windows.Forms.Padding(3);
            this.pageStat.Size = new System.Drawing.Size(625, 324);
            this.pageStat.TabIndex = 4;
            this.pageStat.Text = "Consultation des statistiques";
            this.pageStat.UseVisualStyleBackColor = true;
            // 
            // pageProfil
            // 
            this.pageProfil.Controls.Add(richTextBox2);
            this.pageProfil.Controls.Add(this.label4);
            this.pageProfil.Controls.Add(this.pictureBox4);
            this.pageProfil.Location = new System.Drawing.Point(4, 22);
            this.pageProfil.Name = "pageProfil";
            this.pageProfil.Padding = new System.Windows.Forms.Padding(3);
            this.pageProfil.Size = new System.Drawing.Size(625, 324);
            this.pageProfil.TabIndex = 5;
            this.pageProfil.Text = "Votre profil";
            this.pageProfil.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "modification de mot de passe";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::gsb_application.Properties.Resources.changer_mdp;
            this.pictureBox4.Location = new System.Drawing.Point(181, 6);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(235, 178);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(235, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 178);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "Aide";
            this.Text = "Aide";
            this.tabControl1.ResumeLayout(false);
            this.pageConnexion.ResumeLayout(false);
            this.pageConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pageCreerUtilisateur.ResumeLayout(false);
            this.pageCreerUtilisateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pageProfil.ResumeLayout(false);
            this.pageProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage pageConnexion;
        private TabPage pageSaisiePret;
        private TabPage pageConsultationPret;
        private TabPage pageCreerUtilisateur;
        private TabPage pageStat;
        private TabPage pageProfil;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label5;



    }
}
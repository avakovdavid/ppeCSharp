namespace gsb_application
{
    partial class Administration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEmploye = new System.Windows.Forms.Panel();
            this.btnCreerEmploye = new System.Windows.Forms.Button();
            this.tfdEmailE = new System.Windows.Forms.TextBox();
            this.tfdPrenomE = new System.Windows.Forms.TextBox();
            this.tfdNomE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.tfdMdpCA = new System.Windows.Forms.TextBox();
            this.btnCreerAdmin = new System.Windows.Forms.Button();
            this.tfdMdpA = new System.Windows.Forms.TextBox();
            this.tfdLoginA = new System.Windows.Forms.TextBox();
            this.tfdEmailA = new System.Windows.Forms.TextBox();
            this.tfdPrenomA = new System.Windows.Forms.TextBox();
            this.tfdNomA = new System.Windows.Forms.TextBox();
            this.lblConfirmMdp = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.rbtnEmploye = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEmploye.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlEmploye);
            this.panel1.Controls.Add(this.pnlAdmin);
            this.panel1.Controls.Add(this.rbtnEmploye);
            this.panel1.Controls.Add(this.rbtnAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 263);
            this.panel1.TabIndex = 0;
            // 
            // pnlEmploye
            // 
            this.pnlEmploye.Controls.Add(this.btnCreerEmploye);
            this.pnlEmploye.Controls.Add(this.tfdEmailE);
            this.pnlEmploye.Controls.Add(this.tfdPrenomE);
            this.pnlEmploye.Controls.Add(this.tfdNomE);
            this.pnlEmploye.Controls.Add(this.label2);
            this.pnlEmploye.Controls.Add(this.label3);
            this.pnlEmploye.Controls.Add(this.label4);
            this.pnlEmploye.Location = new System.Drawing.Point(3, 61);
            this.pnlEmploye.Name = "pnlEmploye";
            this.pnlEmploye.Size = new System.Drawing.Size(242, 169);
            this.pnlEmploye.TabIndex = 3;
            this.pnlEmploye.Visible = false;
            // 
            // btnCreerEmploye
            // 
            this.btnCreerEmploye.Location = new System.Drawing.Point(82, 112);
            this.btnCreerEmploye.Name = "btnCreerEmploye";
            this.btnCreerEmploye.Size = new System.Drawing.Size(75, 23);
            this.btnCreerEmploye.TabIndex = 15;
            this.btnCreerEmploye.Text = "Créer";
            this.btnCreerEmploye.UseVisualStyleBackColor = true;
            this.btnCreerEmploye.Click += new System.EventHandler(this.btnCreerEmploye_Click);
            // 
            // tfdEmailE
            // 
            this.tfdEmailE.Location = new System.Drawing.Point(128, 75);
            this.tfdEmailE.Name = "tfdEmailE";
            this.tfdEmailE.Size = new System.Drawing.Size(100, 20);
            this.tfdEmailE.TabIndex = 14;
            // 
            // tfdPrenomE
            // 
            this.tfdPrenomE.Location = new System.Drawing.Point(128, 49);
            this.tfdPrenomE.Name = "tfdPrenomE";
            this.tfdPrenomE.Size = new System.Drawing.Size(100, 20);
            this.tfdPrenomE.TabIndex = 13;
            // 
            // tfdNomE
            // 
            this.tfdNomE.AccessibleName = "";
            this.tfdNomE.Location = new System.Drawing.Point(128, 23);
            this.tfdNomE.Name = "tfdNomE";
            this.tfdNomE.Size = new System.Drawing.Size(100, 20);
            this.tfdNomE.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prénom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom : ";
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.tfdMdpCA);
            this.pnlAdmin.Controls.Add(this.btnCreerAdmin);
            this.pnlAdmin.Controls.Add(this.tfdMdpA);
            this.pnlAdmin.Controls.Add(this.tfdLoginA);
            this.pnlAdmin.Controls.Add(this.tfdEmailA);
            this.pnlAdmin.Controls.Add(this.tfdPrenomA);
            this.pnlAdmin.Controls.Add(this.tfdNomA);
            this.pnlAdmin.Controls.Add(this.lblConfirmMdp);
            this.pnlAdmin.Controls.Add(this.lblMdp);
            this.pnlAdmin.Controls.Add(this.lblLogin);
            this.pnlAdmin.Controls.Add(this.lblEmail);
            this.pnlAdmin.Controls.Add(this.lblPrenom);
            this.pnlAdmin.Controls.Add(this.lblNom);
            this.pnlAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlAdmin.Location = new System.Drawing.Point(3, 65);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(242, 195);
            this.pnlAdmin.TabIndex = 3;
            this.pnlAdmin.Visible = false;
            // 
            // tfdMdpCA
            // 
            this.tfdMdpCA.Location = new System.Drawing.Point(139, 145);
            this.tfdMdpCA.Name = "tfdMdpCA";
            this.tfdMdpCA.Size = new System.Drawing.Size(100, 20);
            this.tfdMdpCA.TabIndex = 11;
            this.tfdMdpCA.UseSystemPasswordChar = true;
            // 
            // btnCreerAdmin
            // 
            this.btnCreerAdmin.Location = new System.Drawing.Point(82, 169);
            this.btnCreerAdmin.Name = "btnCreerAdmin";
            this.btnCreerAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnCreerAdmin.TabIndex = 4;
            this.btnCreerAdmin.Text = "Créer";
            this.btnCreerAdmin.UseVisualStyleBackColor = true;
            this.btnCreerAdmin.Click += new System.EventHandler(this.btnCreerAdmin_Click);
            // 
            // tfdMdpA
            // 
            this.tfdMdpA.Location = new System.Drawing.Point(139, 119);
            this.tfdMdpA.Name = "tfdMdpA";
            this.tfdMdpA.Size = new System.Drawing.Size(100, 20);
            this.tfdMdpA.TabIndex = 10;
            this.tfdMdpA.UseSystemPasswordChar = true;
            // 
            // tfdLoginA
            // 
            this.tfdLoginA.Location = new System.Drawing.Point(139, 93);
            this.tfdLoginA.Name = "tfdLoginA";
            this.tfdLoginA.Size = new System.Drawing.Size(100, 20);
            this.tfdLoginA.TabIndex = 9;
            // 
            // tfdEmailA
            // 
            this.tfdEmailA.Location = new System.Drawing.Point(139, 67);
            this.tfdEmailA.Name = "tfdEmailA";
            this.tfdEmailA.Size = new System.Drawing.Size(100, 20);
            this.tfdEmailA.TabIndex = 8;
            // 
            // tfdPrenomA
            // 
            this.tfdPrenomA.Location = new System.Drawing.Point(139, 41);
            this.tfdPrenomA.Name = "tfdPrenomA";
            this.tfdPrenomA.Size = new System.Drawing.Size(100, 20);
            this.tfdPrenomA.TabIndex = 7;
            // 
            // tfdNomA
            // 
            this.tfdNomA.Location = new System.Drawing.Point(139, 15);
            this.tfdNomA.Name = "tfdNomA";
            this.tfdNomA.Size = new System.Drawing.Size(100, 20);
            this.tfdNomA.TabIndex = 6;
            // 
            // lblConfirmMdp
            // 
            this.lblConfirmMdp.AutoSize = true;
            this.lblConfirmMdp.Location = new System.Drawing.Point(15, 148);
            this.lblConfirmMdp.Name = "lblConfirmMdp";
            this.lblConfirmMdp.Size = new System.Drawing.Size(65, 13);
            this.lblConfirmMdp.TabIndex = 5;
            this.lblConfirmMdp.Text = "Confirmation";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(15, 122);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(80, 13);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Mot de passe : ";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 96);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(42, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(15, 44);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // rbtnEmploye
            // 
            this.rbtnEmploye.AutoSize = true;
            this.rbtnEmploye.Location = new System.Drawing.Point(134, 35);
            this.rbtnEmploye.Name = "rbtnEmploye";
            this.rbtnEmploye.Size = new System.Drawing.Size(65, 17);
            this.rbtnEmploye.TabIndex = 2;
            this.rbtnEmploye.TabStop = true;
            this.rbtnEmploye.Text = "Employé";
            this.rbtnEmploye.UseVisualStyleBackColor = true;
            this.rbtnEmploye.CheckedChanged += new System.EventHandler(this.rbtnEmploye_CheckedChanged);
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(43, 35);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(91, 17);
            this.rbtnAdmin.TabIndex = 1;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Administrateur";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            this.rbtnAdmin.CheckedChanged += new System.EventHandler(this.rbtnAdmin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez le type de l\'utilisateur : ";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 326);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 326);
            this.Name = "Administration";
            this.Text = "Créer un utilisateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEmploye.ResumeLayout(false);
            this.pnlEmploye.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnEmploye;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.Panel pnlEmploye;
        private System.Windows.Forms.Button btnCreerEmploye;
        private System.Windows.Forms.TextBox tfdEmailE;
        private System.Windows.Forms.TextBox tfdPrenomE;
        private System.Windows.Forms.TextBox tfdNomE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.TextBox tfdMdpCA;
        private System.Windows.Forms.Button btnCreerAdmin;
        private System.Windows.Forms.TextBox tfdMdpA;
        private System.Windows.Forms.TextBox tfdLoginA;
        private System.Windows.Forms.TextBox tfdEmailA;
        private System.Windows.Forms.TextBox tfdPrenomA;
        private System.Windows.Forms.TextBox tfdNomA;
        private System.Windows.Forms.Label lblConfirmMdp;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
    }
}
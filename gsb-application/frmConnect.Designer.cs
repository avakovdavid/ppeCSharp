using System.Windows.Forms;
namespace gsb_application
{
    /// <summary>
    /// classe designer pour le formulaire de connexion
    /// </summary>
    partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.tfdMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tfdLogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Controls.Add(this.btnConnexion);
            this.panel1.Controls.Add(this.tfdMdp);
            this.panel1.Controls.Add(this.lblMdp);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.tfdLogin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 238);
            this.panel1.TabIndex = 4;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(260, 130);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(88, 212);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(86, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // tfdMdp
            // 
            this.tfdMdp.Location = new System.Drawing.Point(113, 176);
            this.tfdMdp.Name = "tfdMdp";
            this.tfdMdp.Size = new System.Drawing.Size(100, 20);
            this.tfdMdp.TabIndex = 3;
            this.tfdMdp.UseSystemPasswordChar = true;

            //pour écouter les événements des touches (connexion par la touche entrer du clavier)
            this.tfdMdp.KeyDown += new KeyEventHandler(this.btnConnexion_KeyDown);

            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(28, 179);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(79, 13);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "mot de passe : ";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(28, 139);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "login : ";
            // 
            // tfdLogin
            // 
            this.tfdLogin.Location = new System.Drawing.Point(113, 136);
            this.tfdLogin.Name = "tfdLogin";
            this.tfdLogin.Size = new System.Drawing.Size(100, 20);
            this.tfdLogin.TabIndex = 0;

            //pour écouter les événements des touches (connexion par la touche entrer du clavier)
            this.tfdLogin.KeyDown += new KeyEventHandler(this.btnConnexion_KeyDown);

            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox tfdMdp;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tfdLogin;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}
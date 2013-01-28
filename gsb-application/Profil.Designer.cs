namespace gsb_application
{
    partial class Profil
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
            this.btnValider = new System.Windows.Forms.Button();
            this.lblMdpActuel = new System.Windows.Forms.Label();
            this.lblNvoMdp = new System.Windows.Forms.Label();
            this.lblMdpConfirm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tfdNvoMdpC = new System.Windows.Forms.TextBox();
            this.tfdNvoMdp = new System.Windows.Forms.TextBox();
            this.tfdMdp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(86, 123);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblMdpActuel
            // 
            this.lblMdpActuel.AutoSize = true;
            this.lblMdpActuel.Location = new System.Drawing.Point(18, 20);
            this.lblMdpActuel.Name = "lblMdpActuel";
            this.lblMdpActuel.Size = new System.Drawing.Size(112, 13);
            this.lblMdpActuel.TabIndex = 1;
            this.lblMdpActuel.Text = "Mot de passe actuel : ";
            // 
            // lblNvoMdp
            // 
            this.lblNvoMdp.AutoSize = true;
            this.lblNvoMdp.Location = new System.Drawing.Point(7, 51);
            this.lblNvoMdp.Name = "lblNvoMdp";
            this.lblNvoMdp.Size = new System.Drawing.Size(126, 13);
            this.lblNvoMdp.TabIndex = 2;
            this.lblNvoMdp.Text = "Nouveau mot de passe : ";
            // 
            // lblMdpConfirm
            // 
            this.lblMdpConfirm.AutoSize = true;
            this.lblMdpConfirm.Location = new System.Drawing.Point(56, 81);
            this.lblMdpConfirm.Name = "lblMdpConfirm";
            this.lblMdpConfirm.Size = new System.Drawing.Size(74, 13);
            this.lblMdpConfirm.TabIndex = 3;
            this.lblMdpConfirm.Text = "Confirmation : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tfdNvoMdpC);
            this.panel1.Controls.Add(this.tfdNvoMdp);
            this.panel1.Controls.Add(this.tfdMdp);
            this.panel1.Controls.Add(this.lblMdpActuel);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.lblMdpConfirm);
            this.panel1.Controls.Add(this.lblNvoMdp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 166);
            this.panel1.TabIndex = 4;
            // 
            // tfdNvoMdpC
            // 
            this.tfdNvoMdpC.Location = new System.Drawing.Point(136, 81);
            this.tfdNvoMdpC.Name = "tfdNvoMdpC";
            this.tfdNvoMdpC.Size = new System.Drawing.Size(100, 20);
            this.tfdNvoMdpC.TabIndex = 6;
            // 
            // tfdNvoMdp
            // 
            this.tfdNvoMdp.Location = new System.Drawing.Point(136, 51);
            this.tfdNvoMdp.Name = "tfdNvoMdp";
            this.tfdNvoMdp.Size = new System.Drawing.Size(100, 20);
            this.tfdNvoMdp.TabIndex = 5;
            // 
            // tfdMdp
            // 
            this.tfdMdp.Location = new System.Drawing.Point(136, 20);
            this.tfdMdp.Name = "tfdMdp";
            this.tfdMdp.Size = new System.Drawing.Size(100, 20);
            this.tfdMdp.TabIndex = 4;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(300, 228);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 228);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 228);
            this.Name = "Profil";
            this.Text = "Changer le mot de passe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblMdpActuel;
        private System.Windows.Forms.Label lblNvoMdp;
        private System.Windows.Forms.Label lblMdpConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tfdNvoMdpC;
        private System.Windows.Forms.TextBox tfdNvoMdp;
        private System.Windows.Forms.TextBox tfdMdp;


    }
}
namespace gsb_application
{
    partial class frmNvlLicVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNvlLicVersion));
            this.panel = new System.Windows.Forms.Panel();
            this.lblNumLicVersionAttribue = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.txtBoxNumMatAssoc = new System.Windows.Forms.TextBox();
            this.txtBoxNomVersion = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblNumLicVersionAttribue);
            this.panel.Controls.Add(this.btnAjouter);
            this.panel.Controls.Add(this.btnSupp);
            this.panel.Controls.Add(this.txtBoxNumMatAssoc);
            this.panel.Controls.Add(this.txtBoxNomVersion);
            this.panel.Location = new System.Drawing.Point(2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(311, 28);
            this.panel.TabIndex = 2;
            // 
            // lblNumLicVersionAttribue
            // 
            this.lblNumLicVersionAttribue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLicVersionAttribue.ForeColor = System.Drawing.Color.Red;
            this.lblNumLicVersionAttribue.Location = new System.Drawing.Point(245, 2);
            this.lblNumLicVersionAttribue.Name = "lblNumLicVersionAttribue";
            this.lblNumLicVersionAttribue.Size = new System.Drawing.Size(45, 23);
            this.lblNumLicVersionAttribue.TabIndex = 11;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Location = new System.Drawing.Point(169, 0);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(25, 25);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupp.BackgroundImage")));
            this.btnSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupp.Location = new System.Drawing.Point(200, 0);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(25, 25);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // txtBoxNumMatAssoc
            // 
            this.txtBoxNumMatAssoc.Location = new System.Drawing.Point(109, 3);
            this.txtBoxNumMatAssoc.Name = "txtBoxNumMatAssoc";
            this.txtBoxNumMatAssoc.Size = new System.Drawing.Size(54, 20);
            this.txtBoxNumMatAssoc.TabIndex = 1;
            // 
            // txtBoxNomVersion
            // 
            this.txtBoxNomVersion.Location = new System.Drawing.Point(3, 3);
            this.txtBoxNomVersion.Name = "txtBoxNomVersion";
            this.txtBoxNomVersion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomVersion.TabIndex = 0;
            // 
            // frmNvlLicVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 33);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNvlLicVersion";
            this.Text = "frmNvlLicVersion";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtBoxNumMatAssoc;
        private System.Windows.Forms.TextBox txtBoxNomVersion;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label lblNumLicVersionAttribue;

    }
}
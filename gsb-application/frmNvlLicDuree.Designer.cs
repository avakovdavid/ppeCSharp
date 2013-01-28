namespace gsb_application
{
    partial class frmNvlLicDuree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNvlLicDuree));
            this.panel = new System.Windows.Forms.Panel();
            this.lblNumLicDureeAttribue = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.txtBoxNumMatAssoc = new System.Windows.Forms.TextBox();
            this.txtBoxNomVersion = new System.Windows.Forms.TextBox();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dureeLicence = new System.Windows.Forms.NumericUpDown();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeLicence)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dureeLicence);
            this.panel.Controls.Add(this.lblNumLicDureeAttribue);
            this.panel.Controls.Add(this.btnAjouter);
            this.panel.Controls.Add(this.btnSupp);
            this.panel.Controls.Add(this.txtBoxNumMatAssoc);
            this.panel.Controls.Add(this.txtBoxNomVersion);
            this.panel.Controls.Add(this.dateDebut);
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(554, 27);
            this.panel.TabIndex = 3;
            // 
            // lblNumLicDureeAttribue
            // 
            this.lblNumLicDureeAttribue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLicDureeAttribue.ForeColor = System.Drawing.Color.Red;
            this.lblNumLicDureeAttribue.Location = new System.Drawing.Point(497, 2);
            this.lblNumLicDureeAttribue.Name = "lblNumLicDureeAttribue";
            this.lblNumLicDureeAttribue.Size = new System.Drawing.Size(45, 23);
            this.lblNumLicDureeAttribue.TabIndex = 10;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Location = new System.Drawing.Point(422, 0);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(25, 25);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupp.BackgroundImage")));
            this.btnSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupp.Location = new System.Drawing.Point(453, 0);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(25, 25);
            this.btnSupp.TabIndex = 8;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // txtBoxNumMatAssoc
            // 
            this.txtBoxNumMatAssoc.Location = new System.Drawing.Point(357, 3);
            this.txtBoxNumMatAssoc.Name = "txtBoxNumMatAssoc";
            this.txtBoxNumMatAssoc.Size = new System.Drawing.Size(59, 20);
            this.txtBoxNumMatAssoc.TabIndex = 3;
            // 
            // txtBoxNomVersion
            // 
            this.txtBoxNomVersion.Location = new System.Drawing.Point(3, 3);
            this.txtBoxNomVersion.Name = "txtBoxNomVersion";
            this.txtBoxNomVersion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomVersion.TabIndex = 1;
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(109, 3);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(177, 20);
            this.dateDebut.TabIndex = 0;
            // 
            // dureeLicence
            // 
            this.dureeLicence.Location = new System.Drawing.Point(296, 3);
            this.dureeLicence.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dureeLicence.Name = "dureeLicence";
            this.dureeLicence.Size = new System.Drawing.Size(55, 20);
            this.dureeLicence.TabIndex = 11;
            this.dureeLicence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmNvlLicDuree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 34);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNvlLicDuree";
            this.Text = "frmNvlLicDuree";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeLicence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtBoxNumMatAssoc;
        private System.Windows.Forms.TextBox txtBoxNomVersion;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label lblNumLicDureeAttribue;
        private System.Windows.Forms.NumericUpDown dureeLicence;

    }
}
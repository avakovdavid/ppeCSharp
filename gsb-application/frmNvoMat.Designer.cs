namespace gsb_application
{
    /// <summary>
    /// classe designer pour le formulaire d'un nouveau matériel
    /// </summary>
    partial class frmNvoMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNvoMat));
            this.panel = new System.Windows.Forms.Panel();
            this.lblNumMatAttribue = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.cBoxMarque = new System.Windows.Forms.ComboBox();
            this.garantieMat = new System.Windows.Forms.NumericUpDown();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garantieMat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.garantieMat);
            this.panel.Controls.Add(this.lblNumMatAttribue);
            this.panel.Controls.Add(this.btnAjouter);
            this.panel.Controls.Add(this.btnSupp);
            this.panel.Controls.Add(this.dateTimePicker2);
            this.panel.Controls.Add(this.cBoxType);
            this.panel.Controls.Add(this.cBoxMarque);
            this.panel.Location = new System.Drawing.Point(2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(638, 27);
            this.panel.TabIndex = 5;
            // 
            // lblNumMatAttribue
            // 
            this.lblNumMatAttribue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMatAttribue.ForeColor = System.Drawing.Color.Red;
            this.lblNumMatAttribue.Location = new System.Drawing.Point(571, 3);
            this.lblNumMatAttribue.Name = "lblNumMatAttribue";
            this.lblNumMatAttribue.Size = new System.Drawing.Size(45, 23);
            this.lblNumMatAttribue.TabIndex = 6;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.Location = new System.Drawing.Point(495, 1);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(25, 25);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupp.BackgroundImage")));
            this.btnSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupp.Location = new System.Drawing.Point(526, 1);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(25, 25);
            this.btnSupp.TabIndex = 4;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Location = new System.Drawing.Point(130, 4);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(121, 21);
            this.cBoxType.TabIndex = 1;
            // 
            // cBoxMarque
            // 
            this.cBoxMarque.FormattingEnabled = true;
            this.cBoxMarque.Location = new System.Drawing.Point(3, 4);
            this.cBoxMarque.Name = "cBoxMarque";
            this.cBoxMarque.Size = new System.Drawing.Size(121, 21);
            this.cBoxMarque.TabIndex = 0;
            // 
            // garantieMat
            // 
            this.garantieMat.Location = new System.Drawing.Point(444, 3);
            this.garantieMat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.garantieMat.Name = "garantieMat";
            this.garantieMat.Size = new System.Drawing.Size(45, 20);
            this.garantieMat.TabIndex = 7;
            this.garantieMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmNvoMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 31);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNvoMat";
            this.Text = "frmNvoMat";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.garantieMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.ComboBox cBoxMarque;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNumMatAttribue;
        private System.Windows.Forms.NumericUpDown garantieMat;
    }
}
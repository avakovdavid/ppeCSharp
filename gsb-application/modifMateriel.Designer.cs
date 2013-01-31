namespace gsb_application
{
    /// <summary>
    /// la classe qui remprésente la boite de dialogue pour modifier les données d'un matériel
    /// </summary>
    partial class modifMateriel
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
            this.lblNumMateriel = new System.Windows.Forms.Label();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.garantie = new System.Windows.Forms.NumericUpDown();
            this.dateMiseCirculation = new System.Windows.Forms.DateTimePicker();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.cBoxMarque = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garantie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumMateriel);
            this.panel1.Controls.Add(this.btnAnnul);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.garantie);
            this.panel1.Controls.Add(this.dateMiseCirculation);
            this.panel1.Controls.Add(this.cBoxType);
            this.panel1.Controls.Add(this.cBoxMarque);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 179);
            this.panel1.TabIndex = 0;
            // 
            // lblNumMateriel
            // 
            this.lblNumMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMateriel.ForeColor = System.Drawing.Color.Red;
            this.lblNumMateriel.Location = new System.Drawing.Point(159, 7);
            this.lblNumMateriel.Name = "lblNumMateriel";
            this.lblNumMateriel.Size = new System.Drawing.Size(51, 20);
            this.lblNumMateriel.TabIndex = 5;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnnul.Location = new System.Drawing.Point(157, 146);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(75, 23);
            this.btnAnnul.TabIndex = 11;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnValider.Location = new System.Drawing.Point(76, 146);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Garantie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de mise en circulation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n° du matériel";
            // 
            // garantie
            // 
            this.garantie.Location = new System.Drawing.Point(162, 112);
            this.garantie.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.garantie.Name = "garantie";
            this.garantie.Size = new System.Drawing.Size(47, 20);
            this.garantie.TabIndex = 9;
            this.garantie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.garantie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateMiseCirculation
            // 
            this.dateMiseCirculation.Location = new System.Drawing.Point(162, 85);
            this.dateMiseCirculation.Name = "dateMiseCirculation";
            this.dateMiseCirculation.Size = new System.Drawing.Size(176, 20);
            this.dateMiseCirculation.TabIndex = 8;
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Location = new System.Drawing.Point(162, 57);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(121, 21);
            this.cBoxType.TabIndex = 7;
            // 
            // cBoxMarque
            // 
            this.cBoxMarque.FormattingEnabled = true;
            this.cBoxMarque.Location = new System.Drawing.Point(162, 30);
            this.cBoxMarque.Name = "cBoxMarque";
            this.cBoxMarque.Size = new System.Drawing.Size(121, 21);
            this.cBoxMarque.TabIndex = 6;
            // 
            // modifMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 204);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 232);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 232);
            this.Name = "modifMateriel";
            this.ShowIcon = false;
            this.Text = "Modification du matériel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garantie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown garantie;
        private System.Windows.Forms.DateTimePicker dateMiseCirculation;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.ComboBox cBoxMarque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblNumMateriel;
    }
}
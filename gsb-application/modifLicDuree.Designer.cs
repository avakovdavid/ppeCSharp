namespace gsb_application
{
    partial class modifLicDuree
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
            this.lblNumMatAssoc = new System.Windows.Forms.Label();
            this.lblNumLic = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbAnneeDuree = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateMiseCirculation = new System.Windows.Forms.DateTimePicker();
            this.txtBoxNomLicDuree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAnneeDuree)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumMatAssoc);
            this.panel1.Controls.Add(this.lblNumLic);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nbAnneeDuree);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateMiseCirculation);
            this.panel1.Controls.Add(this.txtBoxNomLicDuree);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAnnul);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 196);
            this.panel1.TabIndex = 0;
            // 
            // lblNumMatAssoc
            // 
            this.lblNumMatAssoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMatAssoc.ForeColor = System.Drawing.Color.Red;
            this.lblNumMatAssoc.Location = new System.Drawing.Point(171, 120);
            this.lblNumMatAssoc.Name = "lblNumMatAssoc";
            this.lblNumMatAssoc.Size = new System.Drawing.Size(51, 20);
            this.lblNumMatAssoc.TabIndex = 11;
            // 
            // lblNumLic
            // 
            this.lblNumLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLic.ForeColor = System.Drawing.Color.Red;
            this.lblNumLic.Location = new System.Drawing.Point(171, 5);
            this.lblNumLic.Name = "lblNumLic";
            this.lblNumLic.Size = new System.Drawing.Size(51, 20);
            this.lblNumLic.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "n°  du matériel associé : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Durée (en années) :";
            // 
            // nbAnneeDuree
            // 
            this.nbAnneeDuree.Location = new System.Drawing.Point(174, 90);
            this.nbAnneeDuree.Name = "nbAnneeDuree";
            this.nbAnneeDuree.Size = new System.Drawing.Size(51, 20);
            this.nbAnneeDuree.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date de mise en circulation : ";
            // 
            // dateMiseCirculation
            // 
            this.dateMiseCirculation.Location = new System.Drawing.Point(174, 64);
            this.dateMiseCirculation.Name = "dateMiseCirculation";
            this.dateMiseCirculation.Size = new System.Drawing.Size(178, 20);
            this.dateMiseCirculation.TabIndex = 5;
            // 
            // txtBoxNomLicDuree
            // 
            this.txtBoxNomLicDuree.Location = new System.Drawing.Point(174, 37);
            this.txtBoxNomLicDuree.Name = "txtBoxNomLicDuree";
            this.txtBoxNomLicDuree.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomLicDuree.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom de la licence : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "n°  de la licence : ";
            // 
            // btnAnnul
            // 
            this.btnAnnul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnnul.Location = new System.Drawing.Point(178, 165);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(75, 23);
            this.btnAnnul.TabIndex = 1;
            this.btnAnnul.Text = "Annuler";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValider.Location = new System.Drawing.Point(97, 165);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // modifLicDuree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 212);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 250);
            this.Name = "modifLicDuree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification de la licence de durée";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAnneeDuree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxNomLicDuree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateMiseCirculation;
        private System.Windows.Forms.NumericUpDown nbAnneeDuree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumMatAssoc;
        private System.Windows.Forms.Label lblNumLic;
    }
}
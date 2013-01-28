namespace gsb_application
{
    partial class statistiqueMateriel
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
            this.titreTableau1 = new System.Windows.Forms.Label();
            this.tableau1 = new System.Windows.Forms.TableLayoutPanel();
            this.numMateriel = new System.Windows.Forms.Label();
            this.dateCirculation = new System.Windows.Forms.Label();
            this.garantie = new System.Windows.Forms.Label();
            this.marque = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableau2 = new System.Windows.Forms.TableLayoutPanel();
            this.numLicence = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.dateDeDebut = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.Label();
            this.numMaterielAssoc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableau1.SuspendLayout();
            this.tableau2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titreTableau1
            // 
            this.titreTableau1.AutoSize = true;
            this.titreTableau1.BackColor = System.Drawing.SystemColors.Control;
            this.titreTableau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreTableau1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titreTableau1.Location = new System.Drawing.Point(3, 0);
            this.titreTableau1.Name = "titreTableau1";
            this.titreTableau1.Size = new System.Drawing.Size(273, 17);
            this.titreTableau1.TabIndex = 0;
            this.titreTableau1.Text = "Les materiels qui ont plus de 5 ans :";
            // 
            // tableau1
            // 
            this.tableau1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableau1.AutoSize = true;
            this.tableau1.BackColor = System.Drawing.SystemColors.Control;
            this.tableau1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableau1.ColumnCount = 5;
            this.tableau1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableau1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableau1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableau1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableau1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableau1.Controls.Add(this.numMateriel, 0, 0);
            this.tableau1.Controls.Add(this.dateCirculation, 1, 0);
            this.tableau1.Controls.Add(this.garantie, 2, 0);
            this.tableau1.Controls.Add(this.marque, 3, 0);
            this.tableau1.Controls.Add(this.type, 4, 0);
            this.tableau1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableau1.Location = new System.Drawing.Point(3, 20);
            this.tableau1.Name = "tableau1";
            this.tableau1.RowCount = 2;
            this.tableau1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableau1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableau1.Size = new System.Drawing.Size(688, 35);
            this.tableau1.TabIndex = 1;
            // 
            // numMateriel
            // 
            this.numMateriel.AutoSize = true;
            this.numMateriel.BackColor = System.Drawing.SystemColors.Control;
            this.numMateriel.Location = new System.Drawing.Point(6, 3);
            this.numMateriel.Name = "numMateriel";
            this.numMateriel.Size = new System.Drawing.Size(56, 13);
            this.numMateriel.TabIndex = 0;
            this.numMateriel.Text = "n° materiel";
            // 
            // dateCirculation
            // 
            this.dateCirculation.AutoSize = true;
            this.dateCirculation.BackColor = System.Drawing.SystemColors.Control;
            this.dateCirculation.Location = new System.Drawing.Point(71, 3);
            this.dateCirculation.Name = "dateCirculation";
            this.dateCirculation.Size = new System.Drawing.Size(135, 13);
            this.dateCirculation.TabIndex = 1;
            this.dateCirculation.Text = "Date de mise en circulation";
            // 
            // garantie
            // 
            this.garantie.AutoSize = true;
            this.garantie.BackColor = System.Drawing.SystemColors.Control;
            this.garantie.Location = new System.Drawing.Point(430, 3);
            this.garantie.Name = "garantie";
            this.garantie.Size = new System.Drawing.Size(47, 13);
            this.garantie.TabIndex = 2;
            this.garantie.Text = "Garantie";
            // 
            // marque
            // 
            this.marque.AutoSize = true;
            this.marque.BackColor = System.Drawing.SystemColors.Control;
            this.marque.Location = new System.Drawing.Point(519, 3);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(43, 13);
            this.marque.TabIndex = 3;
            this.marque.Text = "Marque";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.SystemColors.Control;
            this.type.Location = new System.Drawing.Point(598, 3);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 4;
            this.type.Text = "Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Les licences qui expirent dans moins de 15 jours :";
            // 
            // tableau2
            // 
            this.tableau2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableau2.AutoSize = true;
            this.tableau2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableau2.ColumnCount = 5;
            this.tableau2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.55245F));
            this.tableau2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.44755F));
            this.tableau2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableau2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableau2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableau2.Controls.Add(this.numLicence, 0, 0);
            this.tableau2.Controls.Add(this.nom, 1, 0);
            this.tableau2.Controls.Add(this.dateDeDebut, 2, 0);
            this.tableau2.Controls.Add(this.duree, 3, 0);
            this.tableau2.Controls.Add(this.numMaterielAssoc, 4, 0);
            this.tableau2.Location = new System.Drawing.Point(3, 78);
            this.tableau2.Name = "tableau2";
            this.tableau2.RowCount = 2;
            this.tableau2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.30435F));
            this.tableau2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.69565F));
            this.tableau2.Size = new System.Drawing.Size(688, 42);
            this.tableau2.TabIndex = 3;
            // 
            // numLicence
            // 
            this.numLicence.AutoSize = true;
            this.numLicence.Location = new System.Drawing.Point(6, 3);
            this.numLicence.Name = "numLicence";
            this.numLicence.Size = new System.Drawing.Size(54, 13);
            this.numLicence.TabIndex = 0;
            this.numLicence.Text = "n° licence";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(174, 3);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(29, 13);
            this.nom.TabIndex = 1;
            this.nom.Text = "Nom";
            // 
            // dateDeDebut
            // 
            this.dateDeDebut.AutoSize = true;
            this.dateDeDebut.Location = new System.Drawing.Point(360, 3);
            this.dateDeDebut.Name = "dateDeDebut";
            this.dateDeDebut.Size = new System.Drawing.Size(75, 13);
            this.dateDeDebut.TabIndex = 2;
            this.dateDeDebut.Text = "Date de debut";
            // 
            // duree
            // 
            this.duree.AutoSize = true;
            this.duree.Location = new System.Drawing.Point(473, 3);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(36, 13);
            this.duree.TabIndex = 3;
            this.duree.Text = "Durée";
            // 
            // numMaterielAssoc
            // 
            this.numMaterielAssoc.AutoSize = true;
            this.numMaterielAssoc.Location = new System.Drawing.Point(537, 3);
            this.numMaterielAssoc.Name = "numMaterielAssoc";
            this.numMaterielAssoc.Size = new System.Drawing.Size(95, 13);
            this.numMaterielAssoc.TabIndex = 4;
            this.numMaterielAssoc.Text = "n° matériel associé";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.titreTableau1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableau2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableau1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 134);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // statistiqueMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 328);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "statistiqueMateriel";
            this.Text = "Statistique Materiel";
            this.tableau1.ResumeLayout(false);
            this.tableau1.PerformLayout();
            this.tableau2.ResumeLayout(false);
            this.tableau2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreTableau1;
        private System.Windows.Forms.TableLayoutPanel tableau1;
        private System.Windows.Forms.Label numMateriel;
        private System.Windows.Forms.Label dateCirculation;
        private System.Windows.Forms.Label garantie;
        private System.Windows.Forms.Label marque;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableau2;
        private System.Windows.Forms.Label numLicence;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label dateDeDebut;
        private System.Windows.Forms.Label duree;
        private System.Windows.Forms.Label numMaterielAssoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
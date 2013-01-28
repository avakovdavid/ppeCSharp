namespace gsb_application
{
    partial class frmResume
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxMateriel = new System.Windows.Forms.GroupBox();
            this.grpBoxLicVersion = new System.Windows.Forms.GroupBox();
            this.grpBoxLicDuree = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxQui = new System.Windows.Forms.ListBox();
            this.lblQui = new System.Windows.Forms.Label();
            this.tableLayoutMat = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumMat = new System.Windows.Forms.Label();
            this.lblDateCirculeMat = new System.Windows.Forms.Label();
            this.lblGarantieMat = new System.Windows.Forms.Label();
            this.lblMarqueMat = new System.Windows.Forms.Label();
            this.lblTypeMat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutLicDuree = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumMatAssocLicDuree = new System.Windows.Forms.Label();
            this.lblDureeLicDuree = new System.Windows.Forms.Label();
            this.lblDateDebutLicDuree = new System.Windows.Forms.Label();
            this.lblNumLicDuree = new System.Windows.Forms.Label();
            this.lblTitreLicDuree = new System.Windows.Forms.Label();
            this.tableLayoutLicVersion = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumMatLicVersion = new System.Windows.Forms.Label();
            this.lblNumLicVersion = new System.Windows.Forms.Label();
            this.lblTitreLicVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.grpBoxMateriel.SuspendLayout();
            this.grpBoxLicVersion.SuspendLayout();
            this.grpBoxLicDuree.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutMat.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutLicDuree.SuspendLayout();
            this.tableLayoutLicVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.grpBoxMateriel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.grpBoxLicVersion, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.grpBoxLicDuree, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 103);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(620, 192);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // grpBoxMateriel
            // 
            this.grpBoxMateriel.AutoSize = true;
            this.grpBoxMateriel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxMateriel.Controls.Add(this.tableLayoutMat);
            this.grpBoxMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMateriel.Location = new System.Drawing.Point(3, 3);
            this.grpBoxMateriel.Name = "grpBoxMateriel";
            this.grpBoxMateriel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxMateriel.Size = new System.Drawing.Size(369, 58);
            this.grpBoxMateriel.TabIndex = 5;
            this.grpBoxMateriel.TabStop = false;
            this.grpBoxMateriel.Text = "Les matériels : ";
            // 
            // grpBoxLicVersion
            // 
            this.grpBoxLicVersion.AutoSize = true;
            this.grpBoxLicVersion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxLicVersion.Controls.Add(this.tableLayoutLicVersion);
            this.grpBoxLicVersion.Location = new System.Drawing.Point(3, 131);
            this.grpBoxLicVersion.Name = "grpBoxLicVersion";
            this.grpBoxLicVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxLicVersion.Size = new System.Drawing.Size(207, 58);
            this.grpBoxLicVersion.TabIndex = 8;
            this.grpBoxLicVersion.TabStop = false;
            this.grpBoxLicVersion.Text = "Les licences de version : ";
            // 
            // grpBoxLicDuree
            // 
            this.grpBoxLicDuree.AutoSize = true;
            this.grpBoxLicDuree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxLicDuree.Controls.Add(this.tableLayoutLicDuree);
            this.grpBoxLicDuree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxLicDuree.Location = new System.Drawing.Point(3, 67);
            this.grpBoxLicDuree.Name = "grpBoxLicDuree";
            this.grpBoxLicDuree.Size = new System.Drawing.Size(330, 58);
            this.grpBoxLicDuree.TabIndex = 6;
            this.grpBoxLicDuree.TabStop = false;
            this.grpBoxLicDuree.Text = "Les licences de durée : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.listBoxQui);
            this.panel1.Controls.Add(this.lblQui);
            this.panel1.Location = new System.Drawing.Point(292, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 85);
            this.panel1.TabIndex = 8;
            // 
            // listBoxQui
            // 
            this.listBoxQui.FormattingEnabled = true;
            this.listBoxQui.Location = new System.Drawing.Point(61, 11);
            this.listBoxQui.Name = "listBoxQui";
            this.listBoxQui.Size = new System.Drawing.Size(116, 69);
            this.listBoxQui.TabIndex = 6;
            this.listBoxQui.SelectedIndexChanged += new System.EventHandler(this.listBoxQui_SelectedIndexChanged);
            // 
            // lblQui
            // 
            this.lblQui.AutoSize = true;
            this.lblQui.Location = new System.Drawing.Point(23, 35);
            this.lblQui.Name = "lblQui";
            this.lblQui.Size = new System.Drawing.Size(32, 13);
            this.lblQui.TabIndex = 0;
            this.lblQui.Text = "Qui : ";
            // 
            // tableLayoutMat
            // 
            this.tableLayoutMat.AutoSize = true;
            this.tableLayoutMat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutMat.ColumnCount = 6;
            this.tableLayoutMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMat.Controls.Add(this.lblTypeMat, 4, 0);
            this.tableLayoutMat.Controls.Add(this.lblMarqueMat, 3, 0);
            this.tableLayoutMat.Controls.Add(this.lblGarantieMat, 2, 0);
            this.tableLayoutMat.Controls.Add(this.lblNumMat, 0, 0);
            this.tableLayoutMat.Controls.Add(this.lblDateCirculeMat, 1, 0);
            this.tableLayoutMat.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutMat.Name = "tableLayoutMat";
            this.tableLayoutMat.RowCount = 1;
            this.tableLayoutMat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMat.Size = new System.Drawing.Size(357, 20);
            this.tableLayoutMat.TabIndex = 0;
            // 
            // lblNumMat
            // 
            this.lblNumMat.AutoSize = true;
            this.lblNumMat.Location = new System.Drawing.Point(3, 0);
            this.lblNumMat.Name = "lblNumMat";
            this.lblNumMat.Size = new System.Drawing.Size(71, 13);
            this.lblNumMat.TabIndex = 0;
            this.lblNumMat.Text = "n° du matériel";
            // 
            // lblDateCirculeMat
            // 
            this.lblDateCirculeMat.AutoSize = true;
            this.lblDateCirculeMat.Location = new System.Drawing.Point(80, 0);
            this.lblDateCirculeMat.Name = "lblDateCirculeMat";
            this.lblDateCirculeMat.Size = new System.Drawing.Size(135, 13);
            this.lblDateCirculeMat.TabIndex = 1;
            this.lblDateCirculeMat.Text = "Date de mise en circulation";
            // 
            // lblGarantieMat
            // 
            this.lblGarantieMat.AutoSize = true;
            this.lblGarantieMat.Location = new System.Drawing.Point(221, 0);
            this.lblGarantieMat.Name = "lblGarantieMat";
            this.lblGarantieMat.Size = new System.Drawing.Size(47, 13);
            this.lblGarantieMat.TabIndex = 2;
            this.lblGarantieMat.Text = "Garantie";
            // 
            // lblMarqueMat
            // 
            this.lblMarqueMat.AutoSize = true;
            this.lblMarqueMat.Location = new System.Drawing.Point(274, 0);
            this.lblMarqueMat.Name = "lblMarqueMat";
            this.lblMarqueMat.Size = new System.Drawing.Size(43, 13);
            this.lblMarqueMat.TabIndex = 3;
            this.lblMarqueMat.Text = "Marque";
            // 
            // lblTypeMat
            // 
            this.lblTypeMat.AutoSize = true;
            this.lblTypeMat.Location = new System.Drawing.Point(323, 0);
            this.lblTypeMat.Name = "lblTypeMat";
            this.lblTypeMat.Size = new System.Drawing.Size(31, 13);
            this.lblTypeMat.TabIndex = 4;
            this.lblTypeMat.Text = "Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type";
            // 
            // tableLayoutLicDuree
            // 
            this.tableLayoutLicDuree.AutoSize = true;
            this.tableLayoutLicDuree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLicDuree.ColumnCount = 7;
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicDuree.Controls.Add(this.lblNumMatAssocLicDuree, 4, 0);
            this.tableLayoutLicDuree.Controls.Add(this.lblDureeLicDuree, 3, 0);
            this.tableLayoutLicDuree.Controls.Add(this.lblDateDebutLicDuree, 2, 0);
            this.tableLayoutLicDuree.Controls.Add(this.lblNumLicDuree, 0, 0);
            this.tableLayoutLicDuree.Controls.Add(this.lblTitreLicDuree, 1, 0);
            this.tableLayoutLicDuree.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutLicDuree.Name = "tableLayoutLicDuree";
            this.tableLayoutLicDuree.RowCount = 1;
            this.tableLayoutLicDuree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLicDuree.Size = new System.Drawing.Size(318, 20);
            this.tableLayoutLicDuree.TabIndex = 1;
            // 
            // lblNumMatAssocLicDuree
            // 
            this.lblNumMatAssocLicDuree.AutoSize = true;
            this.lblNumMatAssocLicDuree.Location = new System.Drawing.Point(220, 0);
            this.lblNumMatAssocLicDuree.Name = "lblNumMatAssocLicDuree";
            this.lblNumMatAssocLicDuree.Size = new System.Drawing.Size(95, 13);
            this.lblNumMatAssocLicDuree.TabIndex = 4;
            this.lblNumMatAssocLicDuree.Text = "n° matériel associé";
            // 
            // lblDureeLicDuree
            // 
            this.lblDureeLicDuree.AutoSize = true;
            this.lblDureeLicDuree.Location = new System.Drawing.Point(178, 0);
            this.lblDureeLicDuree.Name = "lblDureeLicDuree";
            this.lblDureeLicDuree.Size = new System.Drawing.Size(36, 13);
            this.lblDureeLicDuree.TabIndex = 3;
            this.lblDureeLicDuree.Text = "Durée";
            // 
            // lblDateDebutLicDuree
            // 
            this.lblDateDebutLicDuree.AutoSize = true;
            this.lblDateDebutLicDuree.Location = new System.Drawing.Point(97, 0);
            this.lblDateDebutLicDuree.Name = "lblDateDebutLicDuree";
            this.lblDateDebutLicDuree.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebutLicDuree.TabIndex = 2;
            this.lblDateDebutLicDuree.Text = "Date du début";
            // 
            // lblNumLicDuree
            // 
            this.lblNumLicDuree.AutoSize = true;
            this.lblNumLicDuree.Location = new System.Drawing.Point(3, 0);
            this.lblNumLicDuree.Name = "lblNumLicDuree";
            this.lblNumLicDuree.Size = new System.Drawing.Size(54, 13);
            this.lblNumLicDuree.TabIndex = 0;
            this.lblNumLicDuree.Text = "n° licence";
            // 
            // lblTitreLicDuree
            // 
            this.lblTitreLicDuree.AutoSize = true;
            this.lblTitreLicDuree.Location = new System.Drawing.Point(63, 0);
            this.lblTitreLicDuree.Name = "lblTitreLicDuree";
            this.lblTitreLicDuree.Size = new System.Drawing.Size(28, 13);
            this.lblTitreLicDuree.TabIndex = 1;
            this.lblTitreLicDuree.Text = "Titre";
            // 
            // tableLayoutLicVersion
            // 
            this.tableLayoutLicVersion.AutoSize = true;
            this.tableLayoutLicVersion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLicVersion.ColumnCount = 5;
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLicVersion.Controls.Add(this.lblNumMatLicVersion, 2, 0);
            this.tableLayoutLicVersion.Controls.Add(this.lblNumLicVersion, 0, 0);
            this.tableLayoutLicVersion.Controls.Add(this.lblTitreLicVersion, 1, 0);
            this.tableLayoutLicVersion.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutLicVersion.Name = "tableLayoutLicVersion";
            this.tableLayoutLicVersion.RowCount = 1;
            this.tableLayoutLicVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutLicVersion.Size = new System.Drawing.Size(195, 20);
            this.tableLayoutLicVersion.TabIndex = 2;
            // 
            // lblNumMatLicVersion
            // 
            this.lblNumMatLicVersion.AutoSize = true;
            this.lblNumMatLicVersion.Location = new System.Drawing.Point(97, 0);
            this.lblNumMatLicVersion.Name = "lblNumMatLicVersion";
            this.lblNumMatLicVersion.Size = new System.Drawing.Size(95, 13);
            this.lblNumMatLicVersion.TabIndex = 4;
            this.lblNumMatLicVersion.Text = "n° matériel associé";
            // 
            // lblNumLicVersion
            // 
            this.lblNumLicVersion.AutoSize = true;
            this.lblNumLicVersion.Location = new System.Drawing.Point(3, 0);
            this.lblNumLicVersion.Name = "lblNumLicVersion";
            this.lblNumLicVersion.Size = new System.Drawing.Size(54, 13);
            this.lblNumLicVersion.TabIndex = 0;
            this.lblNumLicVersion.Text = "n° licence";
            // 
            // lblTitreLicVersion
            // 
            this.lblTitreLicVersion.AutoSize = true;
            this.lblTitreLicVersion.Location = new System.Drawing.Point(63, 0);
            this.lblTitreLicVersion.Name = "lblTitreLicVersion";
            this.lblTitreLicVersion.Size = new System.Drawing.Size(28, 13);
            this.lblTitreLicVersion.TabIndex = 1;
            this.lblTitreLicVersion.Text = "Titre";
            // 
            // frmResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmResume";
            this.Text = "Résumé des prêts";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.grpBoxMateriel.ResumeLayout(false);
            this.grpBoxMateriel.PerformLayout();
            this.grpBoxLicVersion.ResumeLayout(false);
            this.grpBoxLicVersion.PerformLayout();
            this.grpBoxLicDuree.ResumeLayout(false);
            this.grpBoxLicDuree.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutMat.ResumeLayout(false);
            this.tableLayoutMat.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutLicDuree.ResumeLayout(false);
            this.tableLayoutLicDuree.PerformLayout();
            this.tableLayoutLicVersion.ResumeLayout(false);
            this.tableLayoutLicVersion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox grpBoxMateriel;
        private System.Windows.Forms.GroupBox grpBoxLicVersion;
        private System.Windows.Forms.GroupBox grpBoxLicDuree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxQui;
        private System.Windows.Forms.Label lblQui;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMat;
        private System.Windows.Forms.Label lblNumMat;
        private System.Windows.Forms.Label lblTypeMat;
        private System.Windows.Forms.Label lblMarqueMat;
        private System.Windows.Forms.Label lblGarantieMat;
        private System.Windows.Forms.Label lblDateCirculeMat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLicDuree;
        private System.Windows.Forms.Label lblNumMatAssocLicDuree;
        private System.Windows.Forms.Label lblDureeLicDuree;
        private System.Windows.Forms.Label lblDateDebutLicDuree;
        private System.Windows.Forms.Label lblNumLicDuree;
        private System.Windows.Forms.Label lblTitreLicDuree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLicVersion;
        private System.Windows.Forms.Label lblNumMatLicVersion;
        private System.Windows.Forms.Label lblNumLicVersion;
        private System.Windows.Forms.Label lblTitreLicVersion;
    }
}
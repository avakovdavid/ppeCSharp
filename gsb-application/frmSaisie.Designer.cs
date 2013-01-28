using System.Collections.Generic;
using System.Windows.Forms;
namespace gsb_application
{
    partial class frmSaisie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbLicVersion = new System.Windows.Forms.CheckBox();
            this.chbLicDuree = new System.Windows.Forms.CheckBox();
            this.chbMateriel = new System.Windows.Forms.CheckBox();
            this.lblQui = new System.Windows.Forms.Label();
            this.grpBoxMateriel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGarantie = new System.Windows.Forms.Label();
            this.lblDateCirculation = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.tblFrmMat = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxLicDuree = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActionLicDuree = new System.Windows.Forms.Label();
            this.lblNumMatAssocLicDuree = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblDateDebutLicDuree = new System.Windows.Forms.Label();
            this.lblNomLicDuree = new System.Windows.Forms.Label();
            this.tblFrmLicDuree = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxLicVersion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActionLicVersion = new System.Windows.Forms.Label();
            this.lblNumMatAssocLicVersion = new System.Windows.Forms.Label();
            this.lblNomLicVersion = new System.Windows.Forms.Label();
            this.tblFrmLicVersion = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpBoxMateriel.SuspendLayout();
            this.grpBoxLicDuree.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxLicVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chbLicVersion);
            this.panel1.Controls.Add(this.chbLicDuree);
            this.panel1.Controls.Add(this.chbMateriel);
            this.panel1.Controls.Add(this.lblQui);
            this.panel1.Location = new System.Drawing.Point(196, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 85);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(61, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 69);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "* Quoi : ";
            // 
            // chbLicVersion
            // 
            this.chbLicVersion.AutoSize = true;
            this.chbLicVersion.Location = new System.Drawing.Point(247, 57);
            this.chbLicVersion.Name = "chbLicVersion";
            this.chbLicVersion.Size = new System.Drawing.Size(127, 17);
            this.chbLicVersion.TabIndex = 4;
            this.chbLicVersion.Text = "Licence(s) de version";
            this.chbLicVersion.UseVisualStyleBackColor = true;
            this.chbLicVersion.CheckedChanged += new System.EventHandler(this.chbLicVersion_CheckedChanged);
            // 
            // chbLicDuree
            // 
            this.chbLicDuree.AutoSize = true;
            this.chbLicDuree.Location = new System.Drawing.Point(247, 34);
            this.chbLicDuree.Name = "chbLicDuree";
            this.chbLicDuree.Size = new System.Drawing.Size(120, 17);
            this.chbLicDuree.TabIndex = 3;
            this.chbLicDuree.Text = "Licence(s) de durée";
            this.chbLicDuree.UseVisualStyleBackColor = true;
            this.chbLicDuree.CheckedChanged += new System.EventHandler(this.chbLicDuree_CheckedChanged);
            // 
            // chbMateriel
            // 
            this.chbMateriel.AutoSize = true;
            this.chbMateriel.Location = new System.Drawing.Point(247, 11);
            this.chbMateriel.Name = "chbMateriel";
            this.chbMateriel.Size = new System.Drawing.Size(74, 17);
            this.chbMateriel.TabIndex = 2;
            this.chbMateriel.Text = "Matériel(s)";
            this.chbMateriel.UseVisualStyleBackColor = true;
            this.chbMateriel.CheckedChanged += new System.EventHandler(this.chbMateriel_CheckedChanged);
            // 
            // lblQui
            // 
            this.lblQui.AutoSize = true;
            this.lblQui.Location = new System.Drawing.Point(23, 35);
            this.lblQui.Name = "lblQui";
            this.lblQui.Size = new System.Drawing.Size(39, 13);
            this.lblQui.TabIndex = 0;
            this.lblQui.Text = "* Qui : ";
            // 
            // grpBoxMateriel
            // 
            this.grpBoxMateriel.AutoSize = true;
            this.grpBoxMateriel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxMateriel.Controls.Add(this.label2);
            this.grpBoxMateriel.Controls.Add(this.lblAction);
            this.grpBoxMateriel.Controls.Add(this.button1);
            this.grpBoxMateriel.Controls.Add(this.lblGarantie);
            this.grpBoxMateriel.Controls.Add(this.lblDateCirculation);
            this.grpBoxMateriel.Controls.Add(this.lblType);
            this.grpBoxMateriel.Controls.Add(this.lblMarque);
            this.grpBoxMateriel.Controls.Add(this.tblFrmMat);
            this.grpBoxMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMateriel.Location = new System.Drawing.Point(3, 3);
            this.grpBoxMateriel.Name = "grpBoxMateriel";
            this.grpBoxMateriel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxMateriel.Size = new System.Drawing.Size(682, 97);
            this.grpBoxMateriel.TabIndex = 5;
            this.grpBoxMateriel.TabStop = false;
            this.grpBoxMateriel.Text = "Les matériels : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "n° attribué : ";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(509, 52);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(46, 13);
            this.lblAction.TabIndex = 12;
            this.lblAction.Text = "Action : ";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(647, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGarantie
            // 
            this.lblGarantie.AutoSize = true;
            this.lblGarantie.Location = new System.Drawing.Point(446, 52);
            this.lblGarantie.Name = "lblGarantie";
            this.lblGarantie.Size = new System.Drawing.Size(63, 13);
            this.lblGarantie.TabIndex = 11;
            this.lblGarantie.Text = "* Garantie : ";
            // 
            // lblDateCirculation
            // 
            this.lblDateCirculation.AutoSize = true;
            this.lblDateCirculation.Location = new System.Drawing.Point(268, 52);
            this.lblDateCirculation.Name = "lblDateCirculation";
            this.lblDateCirculation.Size = new System.Drawing.Size(151, 13);
            this.lblDateCirculation.TabIndex = 10;
            this.lblDateCirculation.Text = "* Date de mise en circulation : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(144, 52);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "* Type : ";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(16, 52);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(59, 13);
            this.lblMarque.TabIndex = 8;
            this.lblMarque.Text = "* Marque : ";
            // 
            // tblFrmMat
            // 
            this.tblFrmMat.AutoSize = true;
            this.tblFrmMat.ColumnCount = 1;
            this.tblFrmMat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFrmMat.Location = new System.Drawing.Point(5, 68);
            this.tblFrmMat.Name = "tblFrmMat";
            this.tblFrmMat.RowCount = 1;
            this.tblFrmMat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblFrmMat.Size = new System.Drawing.Size(671, 10);
            this.tblFrmMat.TabIndex = 7;
            // 
            // grpBoxLicDuree
            // 
            this.grpBoxLicDuree.AutoSize = true;
            this.grpBoxLicDuree.Controls.Add(this.label3);
            this.grpBoxLicDuree.Controls.Add(this.lblActionLicDuree);
            this.grpBoxLicDuree.Controls.Add(this.lblNumMatAssocLicDuree);
            this.grpBoxLicDuree.Controls.Add(this.lblDuree);
            this.grpBoxLicDuree.Controls.Add(this.lblDateDebutLicDuree);
            this.grpBoxLicDuree.Controls.Add(this.lblNomLicDuree);
            this.grpBoxLicDuree.Controls.Add(this.tblFrmLicDuree);
            this.grpBoxLicDuree.Controls.Add(this.button2);
            this.grpBoxLicDuree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxLicDuree.Location = new System.Drawing.Point(3, 106);
            this.grpBoxLicDuree.Name = "grpBoxLicDuree";
            this.grpBoxLicDuree.Size = new System.Drawing.Size(614, 91);
            this.grpBoxLicDuree.TabIndex = 6;
            this.grpBoxLicDuree.TabStop = false;
            this.grpBoxLicDuree.Text = "Les licences de durée : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "n° attribué : ";
            // 
            // lblActionLicDuree
            // 
            this.lblActionLicDuree.AutoSize = true;
            this.lblActionLicDuree.Location = new System.Drawing.Point(446, 46);
            this.lblActionLicDuree.Name = "lblActionLicDuree";
            this.lblActionLicDuree.Size = new System.Drawing.Size(46, 13);
            this.lblActionLicDuree.TabIndex = 13;
            this.lblActionLicDuree.Text = "Action : ";
            // 
            // lblNumMatAssocLicDuree
            // 
            this.lblNumMatAssocLicDuree.AutoSize = true;
            this.lblNumMatAssocLicDuree.Location = new System.Drawing.Point(355, 46);
            this.lblNumMatAssocLicDuree.Name = "lblNumMatAssocLicDuree";
            this.lblNumMatAssocLicDuree.Size = new System.Drawing.Size(83, 13);
            this.lblNumMatAssocLicDuree.TabIndex = 12;
            this.lblNumMatAssocLicDuree.Text = "n° mat. assoc. : ";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(295, 46);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(52, 13);
            this.lblDuree.TabIndex = 11;
            this.lblDuree.Text = "* Durée : ";
            // 
            // lblDateDebutLicDuree
            // 
            this.lblDateDebutLicDuree.AutoSize = true;
            this.lblDateDebutLicDuree.Location = new System.Drawing.Point(129, 46);
            this.lblDateDebutLicDuree.Name = "lblDateDebutLicDuree";
            this.lblDateDebutLicDuree.Size = new System.Drawing.Size(91, 13);
            this.lblDateDebutLicDuree.TabIndex = 10;
            this.lblDateDebutLicDuree.Text = "* Date du début : ";
            // 
            // lblNomLicDuree
            // 
            this.lblNomLicDuree.AutoSize = true;
            this.lblNomLicDuree.Location = new System.Drawing.Point(16, 46);
            this.lblNomLicDuree.Name = "lblNomLicDuree";
            this.lblNomLicDuree.Size = new System.Drawing.Size(44, 13);
            this.lblNomLicDuree.TabIndex = 9;
            this.lblNomLicDuree.Text = "* Titre : ";
            // 
            // tblFrmLicDuree
            // 
            this.tblFrmLicDuree.AutoSize = true;
            this.tblFrmLicDuree.ColumnCount = 1;
            this.tblFrmLicDuree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblFrmLicDuree.Location = new System.Drawing.Point(3, 62);
            this.tblFrmLicDuree.Name = "tblFrmLicDuree";
            this.tblFrmLicDuree.RowCount = 1;
            this.tblFrmLicDuree.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblFrmLicDuree.Size = new System.Drawing.Size(603, 10);
            this.tblFrmLicDuree.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoEllipsis = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(578, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.grpBoxMateriel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxLicVersion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxLicDuree, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 331);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // grpBoxLicVersion
            // 
            this.grpBoxLicVersion.AutoSize = true;
            this.grpBoxLicVersion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxLicVersion.Controls.Add(this.label4);
            this.grpBoxLicVersion.Controls.Add(this.lblActionLicVersion);
            this.grpBoxLicVersion.Controls.Add(this.lblNumMatAssocLicVersion);
            this.grpBoxLicVersion.Controls.Add(this.lblNomLicVersion);
            this.grpBoxLicVersion.Controls.Add(this.tblFrmLicVersion);
            this.grpBoxLicVersion.Controls.Add(this.button3);
            this.grpBoxLicVersion.Location = new System.Drawing.Point(3, 203);
            this.grpBoxLicVersion.Name = "grpBoxLicVersion";
            this.grpBoxLicVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBoxLicVersion.Size = new System.Drawing.Size(364, 93);
            this.grpBoxLicVersion.TabIndex = 8;
            this.grpBoxLicVersion.TabStop = false;
            this.grpBoxLicVersion.Text = "Les licences de version : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "n° attribué : ";
            // 
            // lblActionLicVersion
            // 
            this.lblActionLicVersion.AutoSize = true;
            this.lblActionLicVersion.Location = new System.Drawing.Point(190, 48);
            this.lblActionLicVersion.Name = "lblActionLicVersion";
            this.lblActionLicVersion.Size = new System.Drawing.Size(46, 13);
            this.lblActionLicVersion.TabIndex = 14;
            this.lblActionLicVersion.Text = "Action : ";
            // 
            // lblNumMatAssocLicVersion
            // 
            this.lblNumMatAssocLicVersion.AutoSize = true;
            this.lblNumMatAssocLicVersion.Location = new System.Drawing.Point(101, 48);
            this.lblNumMatAssocLicVersion.Name = "lblNumMatAssocLicVersion";
            this.lblNumMatAssocLicVersion.Size = new System.Drawing.Size(83, 13);
            this.lblNumMatAssocLicVersion.TabIndex = 13;
            this.lblNumMatAssocLicVersion.Text = "n° mat. assoc. : ";
            // 
            // lblNomLicVersion
            // 
            this.lblNomLicVersion.AutoSize = true;
            this.lblNomLicVersion.Location = new System.Drawing.Point(16, 48);
            this.lblNomLicVersion.Name = "lblNomLicVersion";
            this.lblNomLicVersion.Size = new System.Drawing.Size(44, 13);
            this.lblNomLicVersion.TabIndex = 10;
            this.lblNomLicVersion.Text = "* Titre : ";
            // 
            // tblFrmLicVersion
            // 
            this.tblFrmLicVersion.AutoSize = true;
            this.tblFrmLicVersion.ColumnCount = 1;
            this.tblFrmLicVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblFrmLicVersion.Location = new System.Drawing.Point(6, 64);
            this.tblFrmLicVersion.Name = "tblFrmLicVersion";
            this.tblFrmLicVersion.RowCount = 1;
            this.tblFrmLicVersion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblFrmLicVersion.Size = new System.Drawing.Size(352, 10);
            this.tblFrmLicVersion.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "";
            this.button3.AllowDrop = true;
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoEllipsis = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(328, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(110, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "* : donnée obligatoire ";
            // 
            // frmSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(820, 515);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSaisie";
            this.Text = "Saisie d\'un prêt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxMateriel.ResumeLayout(false);
            this.grpBoxMateriel.PerformLayout();
            this.grpBoxLicDuree.ResumeLayout(false);
            this.grpBoxLicDuree.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpBoxLicVersion.ResumeLayout(false);
            this.grpBoxLicVersion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQui;
        private System.Windows.Forms.CheckBox chbLicVersion;
        private System.Windows.Forms.CheckBox chbLicDuree;
        private System.Windows.Forms.CheckBox chbMateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxMateriel;
        private TableLayoutPanel tblFrmMat;
        private Button button1;
        private Label lblType;
        private Label lblMarque;
        private Label lblDateCirculation;
        private Label lblGarantie;
        private Label label2;
        private Label lblAction;
        private ListBox listBox1;
        private GroupBox grpBoxLicDuree;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpBoxLicVersion;
        private Button button3;
        private TableLayoutPanel tblFrmLicDuree;
        private TableLayoutPanel tblFrmLicVersion;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblNomLicDuree;
        private Label lblActionLicDuree;
        private Label lblNumMatAssocLicDuree;
        private Label lblDuree;
        private Label lblDateDebutLicDuree;
        private Label lblActionLicVersion;
        private Label lblNumMatAssocLicVersion;
        private Label lblNomLicVersion;
        private Label lblInfo;
        private Label label3;
        private Label label4;
    }
}
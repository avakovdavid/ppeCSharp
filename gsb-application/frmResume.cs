using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsb_application
{
    /// <summary>
    /// Classe qui remprésente le module de résumé des prêts. Il permet de consulter les prêts pour une personne donnée.
    /// </summary>
    public partial class frmResume : Form
    {
        /// <summary>
        /// constructeur de la classe
        /// </summary>
        public frmResume()
        {
            InitializeComponent();

            Mysql m = new Mysql();
            //on instancie une liste de personnes
            List<Personne> lesP = new List<Personne>();

            //on la remplie à partir de la base de données
            lesP = m.getLesPersonne();

            //puis on ajoute chaque personne dans la liste (nom + prenom de la personne) 
            for (int i = 0; i < lesP.Count; i++)
            {
                this.listBoxQui.Items.Add(lesP.ElementAt(i).getNomPersonne() + " " + lesP.ElementAt(i).getPrenomPersonne());
            }

            this.init(-1); //aucune personne n'est selectionnée dans la liste au moment de la création de la fenêtre donc le paramètre est : -1

            //this.tableLayoutMat.

        }

        /// <summary>
        /// fonction qui permet d'initialiser certains éléments de l'interface
        /// </summary>
        /// <param name="id">identifiant de la personne dont ont souhaite afficher le résumé (-1 dans le cas d'un premier affichage où aucune personne n'est encore choisie)</param>
        public void init(int id)
        {
            //si aucune personne n'est selectionnée dans la liste :
            if (id != -1)
            {
                Mysql m = new Mysql();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));

                this.tableLayoutMat.Controls.Clear();
                this.tableLayoutLicDuree.Controls.Clear();
                this.tableLayoutLicVersion.Controls.Clear();

                /*TABLEAU DES MATERIELS */
                Label lbl1 = new Label();
                lbl1.Text = "n° du matériel";
                this.tableLayoutMat.Controls.Add(lbl1, 0, 0);

                Label lbl2 = new Label();
                lbl2.Text = "Date de mise en circulation";
                this.tableLayoutMat.Controls.Add(lbl2, 1, 0);

                Label lbl3 = new Label();
                lbl3.Text = "Garantie";
                this.tableLayoutMat.Controls.Add(lbl3, 2, 0);

                Label lbl4 = new Label();
                lbl4.Text = "Marque";
                this.tableLayoutMat.Controls.Add(lbl4, 3, 0);

                Label lbl5 = new Label();
                lbl5.Text = "Type";
                this.tableLayoutMat.Controls.Add(lbl5, 4, 0);


                List<Materiel> lesMat = m.getLesMateriel(id);

                for (int i = 0; i < lesMat.Count; i++)
                {
                    Label lblId = new Label();
                    lblId.Anchor = AnchorStyles.None;
                    lblId.TextAlign = ContentAlignment.MiddleLeft;
                    lblId.Text = lesMat.ElementAt(i).getIdMateriel().ToString();
                    this.tableLayoutMat.Controls.Add(lblId, 0, i + 1);

                    Label lblDate = new Label();
                    lblDate.Anchor = AnchorStyles.Bottom;
                    lblDate.TextAlign = ContentAlignment.MiddleLeft;
                    lblDate.Text = lesMat.ElementAt(i).getDateCirculation().ToString();
                    this.tableLayoutMat.Controls.Add(lblDate, 1, i + 1);

                    Label lblGarantie = new Label();
                    lblGarantie.Anchor = AnchorStyles.None;
                    lblGarantie.TextAlign = ContentAlignment.MiddleLeft;
                    lblGarantie.Text = lesMat.ElementAt(i).getGarantie().ToString() + " an(s)";
                    this.tableLayoutMat.Controls.Add(lblGarantie, 2, i + 1);

                    Label lblMarque = new Label();
                    lblMarque.Anchor = AnchorStyles.None;
                    lblMarque.TextAlign = ContentAlignment.MiddleLeft;
                    lblMarque.Text = lesMat.ElementAt(i).getMarque().getNomMarque();
                    this.tableLayoutMat.Controls.Add(lblMarque, 3, i + 1);

                    Label lblType = new Label();
                    lblType.Anchor = AnchorStyles.None;
                    lblType.TextAlign = ContentAlignment.MiddleLeft;
                    lblType.Text = lesMat.ElementAt(i).getType().getTypeMateriel();
                    this.tableLayoutMat.Controls.Add(lblType, 4, i + 1);

                    Button btnSuppMat = new Button();
                    btnSuppMat.Anchor = AnchorStyles.None;
                    btnSuppMat.TextAlign = ContentAlignment.MiddleLeft;

                    this.tableLayoutMat.Controls.Add(btnSuppMat, 5, i + 1);

                    btnSuppMat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supp")));
                    btnSuppMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btnSuppMat.Size = new System.Drawing.Size(25, 25);
                    btnSuppMat.UseVisualStyleBackColor = true;
                    btnSuppMat.Click += new System.EventHandler(this.btnSuppMat_Click);
                    //btnSuppMat.Get
                }


                /*TABLEAU DES LICENCES DE DUREE*/

                Label lbl7 = new Label();
                lbl7.Text = "n° licence";
                this.tableLayoutLicDuree.Controls.Add(lbl7, 0, 0);

                Label lbl8 = new Label();
                lbl8.Text = "Titre";
                this.tableLayoutLicDuree.Controls.Add(lbl8, 1, 0);

                Label lbl9 = new Label();
                lbl9.Text = "Date du début";
                this.tableLayoutLicDuree.Controls.Add(lbl9, 2, 0);

                Label lbl10 = new Label();
                lbl10.Text = "Durée";
                this.tableLayoutLicDuree.Controls.Add(lbl10, 3, 0);

                Label lbl11 = new Label();
                lbl11.Text = "n° matériel associé";
                this.tableLayoutLicDuree.Controls.Add(lbl11, 4, 0);


                List<Licence_duree> lesLicDur = m.getLesLicenceDuree(id);

                for (int i = 0; i < lesLicDur.Count; i++)
                {
                    Label lblId = new Label();
                    lblId.Anchor = AnchorStyles.None;
                    lblId.TextAlign = ContentAlignment.MiddleLeft;
                    lblId.Text = lesLicDur.ElementAt(i).getIdLicence().ToString();
                    this.tableLayoutLicDuree.Controls.Add(lblId, 0, i + 1);

                    Label lblTitre = new Label();
                    lblTitre.Anchor = AnchorStyles.None;
                    lblTitre.TextAlign = ContentAlignment.MiddleLeft;
                    lblTitre.Text = lesLicDur.ElementAt(i).getNomVersion().ToString();
                    this.tableLayoutLicDuree.Controls.Add(lblTitre, 1, i + 1);

                    Label lblDate = new Label();
                    lblDate.Anchor = AnchorStyles.Bottom;
                    lblDate.TextAlign = ContentAlignment.MiddleLeft;
                    lblDate.Text = lesLicDur.ElementAt(i).getDebutLicence().ToString();
                    this.tableLayoutLicDuree.Controls.Add(lblDate, 2, i + 1);

                    Label lblDuree = new Label();
                    lblDuree.Anchor = AnchorStyles.None;
                    lblDuree.TextAlign = ContentAlignment.MiddleLeft;
                    lblDuree.Text = lesLicDur.ElementAt(i).getDureeLicence() + " an(s)";
                    this.tableLayoutLicDuree.Controls.Add(lblDuree, 3, i + 1);

                    
                    try
                    {
                        Label lblNumMat = new Label();
                        lblNumMat.Anchor = AnchorStyles.None;
                        lblNumMat.TextAlign = ContentAlignment.MiddleLeft;
                        lblNumMat.Text = lesLicDur.ElementAt(i).getMateriel().getIdMateriel().ToString();
                        this.tableLayoutLicDuree.Controls.Add(lblNumMat, 4, i + 1);
                    }
                    catch (Exception ex){}


                    Button btnSuppLicDuree = new Button();
                    Button btnModifLicDuree = new Button();
                    btnSuppLicDuree.Anchor = AnchorStyles.None;
                    btnModifLicDuree.Anchor = AnchorStyles.None;
                    btnSuppLicDuree.TextAlign = ContentAlignment.MiddleLeft;
                    btnModifLicDuree.TextAlign = ContentAlignment.MiddleLeft;

                    this.tableLayoutLicDuree.Controls.Add(btnSuppLicDuree, 5, i + 1);
                    this.tableLayoutLicDuree.Controls.Add(btnModifLicDuree, 6, i + 1);

                    btnSuppLicDuree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supp")));
                    btnSuppLicDuree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btnSuppLicDuree.Size = new System.Drawing.Size(25, 25);
                    btnSuppLicDuree.UseVisualStyleBackColor = true;
                    btnSuppLicDuree.Click += new System.EventHandler(this.btnSuppLicDuree_Click);

                    btnModifLicDuree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit")));
                    btnModifLicDuree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btnModifLicDuree.Size = new System.Drawing.Size(25, 25);
                    btnModifLicDuree.UseVisualStyleBackColor = true;
                    btnModifLicDuree.Click += new System.EventHandler(this.btnModifLicDuree_Click);  
                }



                /*TABLEAU DES LICENCES DE VERSION*/

                Label lbl12 = new Label();
                lbl12.Text = "n° licence";
                this.tableLayoutLicVersion.Controls.Add(lbl12, 0, 0);

                Label lbl13 = new Label();
                lbl13.Text = "Titre";
                this.tableLayoutLicVersion.Controls.Add(lbl13, 1, 0);

                Label lbl14 = new Label();
                lbl14.Text = "n° matériel associé";
                this.tableLayoutLicVersion.Controls.Add(lbl14, 2, 0);


                List<Licence_version> lesLicVersion = m.getLesLicenceVersion(id);

                for (int i = 0; i < lesLicVersion.Count; i++)
                {
                    Label lblId = new Label();
                    lblId.Anchor = AnchorStyles.None;
                    lblId.TextAlign = ContentAlignment.MiddleLeft;
                    lblId.Text = lesLicVersion.ElementAt(i).getIdLicence().ToString();
                    this.tableLayoutLicVersion.Controls.Add(lblId, 0, i + 1);

                    Label lblTitre = new Label();
                    lblTitre.Anchor = AnchorStyles.None;
                    lblTitre.TextAlign = ContentAlignment.MiddleLeft;
                    lblTitre.Text = lesLicVersion.ElementAt(i).getNomVersion().ToString();
                    this.tableLayoutLicVersion.Controls.Add(lblTitre, 1, i + 1);

                    try
                    {
                        Label lblNumMat = new Label();
                        lblNumMat.Anchor = AnchorStyles.None;
                        lblNumMat.TextAlign = ContentAlignment.MiddleLeft;
                        lblNumMat.Text = lesLicVersion.ElementAt(i).getMateriel().getIdMateriel().ToString();
                        this.tableLayoutLicVersion.Controls.Add(lblNumMat, 2, i + 1);
                    }
                    catch (Exception ex) { }


                    Button btnSuppLicVersion = new Button();
                    Button btnModifLicVersion = new Button();
                    btnSuppLicVersion.Anchor = AnchorStyles.None;
                    btnModifLicVersion.Anchor = AnchorStyles.None;
                    btnSuppLicVersion.TextAlign = ContentAlignment.MiddleLeft;
                    btnModifLicVersion.TextAlign = ContentAlignment.MiddleLeft;

                    this.tableLayoutLicVersion.Controls.Add(btnSuppLicVersion, 3, i + 1);
                    this.tableLayoutLicVersion.Controls.Add(btnModifLicVersion, 4, i + 1);

                    btnSuppLicVersion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supp")));
                    btnSuppLicVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btnSuppLicVersion.Size = new System.Drawing.Size(25, 25);
                    btnSuppLicVersion.UseVisualStyleBackColor = true;
                    btnSuppLicVersion.Click += new System.EventHandler(this.btnSuppLicVersion_Click);


                    btnModifLicVersion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit")));
                    btnModifLicVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btnModifLicVersion.Size = new System.Drawing.Size(25, 25);
                    btnModifLicVersion.UseVisualStyleBackColor = true;
                    btnModifLicVersion.Click += new System.EventHandler(this.btnModifLicVersion_Click);                    
                }
            }
        }

        /// <summary>
        /// fonction qui se déclenche lorsque le bouton de modification d'une licence de durée est cliqué. Permet de faire appel à une boite de dialogue pour modifier les données de la licence de durée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnModifLicDuree_Click(object sender, EventArgs e)
        {
            modifLicDuree modif = new modifLicDuree(this,int.Parse(this.tableLayoutLicDuree.GetControlFromPosition(0, this.tableLayoutLicDuree.GetCellPosition((Control)sender).Row).Text));
            modif.ShowDialog();
        }

        /// <summary>
        /// fonction qui se déclenche lorsque le bouton de modification d'une licence de version est cliqué. Permet de faire appel à une boite de dialogue pour modifier les données de la licence de version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnModifLicVersion_Click(object sender, EventArgs e)
        {
            modifLicVersion modif = new modifLicVersion(this, int.Parse(this.tableLayoutLicVersion.GetControlFromPosition(0, this.tableLayoutLicVersion.GetCellPosition((Control)sender).Row).Text));
            modif.ShowDialog();
        }

        /// <summary>
        /// fonction qui se déclenche lorsque le bouton de suppression d'un matériel est cliqué. Permet de supprimer le matériel concerné de la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSuppMat_Click(object sender, EventArgs e)
        {
            Mysql m = new Mysql();
            List<Personne> lesP = m.getLesPersonne();
            
            int idMat = int.Parse(this.tableLayoutMat.GetControlFromPosition(0, this.tableLayoutMat.GetCellPosition((Control)sender).Row).Text);
            try
            {
                List<Licence_duree> lesLicDur = m.getLesLicenceDuree(lesP.ElementAt(this.listBoxQui.SelectedIndex).getIdPersonne(), idMat);
                List<Licence_version> lesLicVersion = m.getLesLicenceVersion(lesP.ElementAt(this.listBoxQui.SelectedIndex).getIdPersonne(), idMat);

                //si il y a des licences de durée associées on va les supprimer
                for (int i = 0; i < lesLicDur.Count; i++)
                {
                    m.suppLicDuree(lesLicDur.ElementAt(i).getIdLicence());
                }

                //si il y des licences de version associées on va les supprimer
                for (int i = 0; i < lesLicVersion.Count; i++)
                {
                    m.suppLicVersion(lesLicVersion.ElementAt(i).getIdLicence());
                }
                
                m.suppMateriel(idMat);

                this.listBoxQui_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// fonction qui se déclenche lorsque le bouton de suppression d'une licence de durée est cliqué. Permet de supprimet la licence de durée concernée de la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSuppLicDuree_Click(object sender, EventArgs e)
        {
            Mysql m = new Mysql();

            try
            {
                m.suppLicDuree(int.Parse(this.tableLayoutLicDuree.GetControlFromPosition(0,this.tableLayoutLicDuree.GetCellPosition((Control)sender).Row).Text));

                this.listBoxQui_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// fonction qui se déclenche lorsque le bouton de suppression d'une licence de version est cliqué. Permet de supprimer la licence de version concernée de la base de données 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSuppLicVersion_Click(object sender, EventArgs e)
        {
            Mysql m = new Mysql();

            try
            {
                m.suppLicVersion(int.Parse(this.tableLayoutLicVersion.GetControlFromPosition(0, this.tableLayoutLicVersion.GetCellPosition((Control)sender).Row).Text));

                this.listBoxQui_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// fonction qui se déclenche lorsque l'utilisateur change la personne dont il souhate consulter les prêts. Permet de faire appel à la fonction de initialisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxQui_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mysql m = new Mysql();
            List<Personne> lesP = m.getLesPersonne();

            init(lesP.ElementAt(this.listBoxQui.SelectedIndex).getIdPersonne());
        }
    }
}

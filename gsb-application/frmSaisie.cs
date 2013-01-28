using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace gsb_application
{
    /// <summary>
    /// Classe qui représente le module de saisie d'un prêt
    /// </summary>
    public partial class frmSaisie : Form 
    {
        private List<frmNvoMat> listeFrmNvoMat; // la liste des formulaires pour ajouter un nouveau materiel
        private List<frmNvlLicDuree> listeFrmNvlLicDuree; // la liste des formulaires pour ajouter une nouvelle licence de durée
        private List<frmNvlLicVersion> listeFrmNvlLicVersion; // la liste des formulaires pour ajouter une nouvelle licence de version

        /// <summary>
        /// Constructeur du module de saisie d'un prêt
        /// </summary>
        public frmSaisie()
        {
            InitializeComponent();
            this.listeFrmNvoMat = new List<frmNvoMat>();
            this.listeFrmNvlLicDuree = new List<frmNvlLicDuree>();
            this.listeFrmNvlLicVersion = new List<frmNvlLicVersion>();

            Mysql m = new Mysql();
            //on instancie une liste de personnes
            List<Personne> lesP = new List<Personne>();

            //on la remplie à partir de la base de données
            lesP = m.getLesPersonne();

            //puis on ajoute chaque personne dans la liste (nom + prenom de la personne) 
            for (int i = 0; i < lesP.Count; i++)
            {
                this.listBox1.Items.Add(lesP.ElementAt(i).getNomPersonne() + " " + lesP.ElementAt(i).getPrenomPersonne());
            }

            this.grpBoxMateriel.Hide();
            this.grpBoxLicDuree.Hide();
            this.grpBoxLicVersion.Hide();

            insertNewFrmMat();
            insertNewFrmLicDuree();
            insertNewFrmLicVersion();
        }

        /// <summary>
        /// Getter de la listBox contenant la liste des utilisateurs
        /// </summary>
        /// <returns>listBox contenant la liste des utilisateurs</returns>
        public ListBox getListBox()
        {
            return this.listBox1;
        }

        /// <summary>
        /// Getter du TableLayoutPanel concernant les matériels
        /// </summary>
        /// <returns>TableLayoutPanel concernant les matériels</returns>
        public TableLayoutPanel getTblMat()
        {
            return this.tblFrmMat;
        }

        /// <summary>
        /// Getter du TableLayoutPanel concernant les licences de durée
        /// </summary>
        /// <returns>TableLayoutPanel concernant les licences de durée</returns>
        public TableLayoutPanel getTblLicDuree()
        {
            return this.tblFrmLicDuree;
        }

        /// <summary>
        /// Getter du TableLayoutPanel concernant les licences de version
        /// </summary>
        /// <returns>TableLayoutPanel concernant les licences de version</returns>
        public TableLayoutPanel getTblLicVersion()
        {
            return this.tblFrmLicVersion;
        }

        /// <summary>
        /// fonction qui permet d'ajouter un formulaire en plus pour un matériel
        /// </summary>
        public void insertNewFrmMat()
        {
            frmNvoMat frmNvoMat = new frmNvoMat(this);
            this.listeFrmNvoMat.Add(frmNvoMat);
            this.tblFrmMat.Controls.Add(frmNvoMat.getPanel());
        }

        /// <summary>
        /// fonction qui permet d'ajouter un formulaire en plus pour une licence de durée
        /// </summary>
        public void insertNewFrmLicDuree()
        {
            frmNvlLicDuree frmNvlLicDuree = new frmNvlLicDuree(this);
            this.listeFrmNvlLicDuree.Add(frmNvlLicDuree);
            this.tblFrmLicDuree.Controls.Add(frmNvlLicDuree.getPanel());
        }

        /// <summary>
        /// fonction qui permet d'ajouter un formulaire en plus pour une licence de version
        /// </summary>
        public void insertNewFrmLicVersion()
        {
            frmNvlLicVersion frmNvlLicVersion = new frmNvlLicVersion(this);
            this.listeFrmNvlLicVersion.Add(frmNvlLicVersion);
            this.tblFrmLicVersion.Controls.Add(frmNvlLicVersion.getPanel());
        }

        /// <summary>
        /// Getter de la liste des formulaires pour un nouveau matériel présents sur la page
        /// </summary>
        /// <returns>liste des formulaires pour un nouveau matériel présents sur la page</returns>
        public List<frmNvoMat> getListeFrmNvoMat()
        {
            return this.listeFrmNvoMat;
        }

        /// <summary>
        /// Getter de la liste des formulaires pour une nouvelle licence de durée présents sur la page
        /// </summary>
        /// <returns>liste des formulaires pour une nouvelle licence de durée présents sur la page</returns>
        public List<frmNvlLicDuree> getListeFrmNvlLicDuree()
        {
            return this.listeFrmNvlLicDuree;
        }

        /// <summary>
        /// Getter de la liste des formulaires pour une nouvelle licence de version présents sur la page
        /// </summary>
        /// <returns>liste des formulaires pour une nouvelle licence de version présents sur la page</returns>
        public List<frmNvlLicVersion> getListeFrmNvlLicVersion()
        {
            return this.listeFrmNvlLicVersion;
        }

        /// <summary>
        /// Fonction qui permet d'inserer en plus un formulaire pour un matériel lorsqu'on clique sur le bouton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            insertNewFrmMat();
        }

        /// <summary>
        /// Fonction qui permet d'inserer en plus un formulaire pour une nouvelle licence de durée lorsqu'on clique sur le bouton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            insertNewFrmLicDuree();
        }

        /// <summary>
        /// Fonction qui permet d'inserer en plus un formulaire pour une licence de version lorsqu'on clique sur le bouton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            insertNewFrmLicVersion();
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur coche ou décoche le prêt d'un matériel. Elle permet d'afficher ou de cacher le formulaire concerné 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbMateriel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbMateriel.Checked)
            {
                if (this.listBox1.SelectedItem != null)
                {
                    this.grpBoxMateriel.Show();
                    Control[] l = this.grpBoxMateriel.Controls.Find("panel", true);
                    for (int i = 0; i < l.Count(); i++)
                    {
                        l.ElementAt(i).Hide();
                    }
                    insertNewFrmMat();
                }
                else
                {
                    this.chbMateriel.Checked = false;
                    MessageBox.Show("Veuillez sélectionner une personne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.grpBoxMateriel.Hide();
            }
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur coche ou décoche le prêt d'une licence de durée. Elle permet d'afficher ou de cacher le formulaire concerné 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbLicDuree_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbLicDuree.Checked)
            {
                if (this.listBox1.SelectedItem != null)
                {
                    this.grpBoxLicDuree.Show();
                    Control[] l = this.grpBoxLicDuree.Controls.Find("panel", true);
                    for (int i = 0; i < l.Count(); i++)
                    {
                        l.ElementAt(i).Hide();
                    }
                    insertNewFrmLicDuree();
                }
                else
                {
                    this.chbLicDuree.Checked = false;
                    MessageBox.Show("Veuillez sélectionner une personne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.grpBoxLicDuree.Hide();
            }
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur coche ou décoche le prêt d'une licence de version. Elle permet d'afficher ou de cacher le formulaire concerné 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbLicVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbLicVersion.Checked)
            {
                if (this.listBox1.SelectedItem != null)
                {
                    this.grpBoxLicVersion.Show();
                    Control[] l = this.grpBoxLicVersion.Controls.Find("panel", true);
                    for (int i = 0; i < l.Count(); i++)
                    {
                        l.ElementAt(i).Hide();
                    }
                    insertNewFrmLicVersion();
                }
                else
                {
                    this.chbLicVersion.Checked = false;
                    MessageBox.Show("Veuillez sélectionner une personne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.grpBoxLicVersion.Hide();
            }
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur clique sur un utilisateur dans la liste. Elle permet d'initialiser la page et enlever les formulaire inutiles 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbMateriel_CheckedChanged(sender, e);
            chbLicDuree_CheckedChanged(sender, e);
            chbLicVersion_CheckedChanged(sender, e);
        }
    }
}

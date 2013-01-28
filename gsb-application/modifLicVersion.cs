using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace gsb_application
{
    /// <summary>
    /// Classe qui représente la boite de dialogue qui permet de modifier les données d'une licence de version
    /// </summary>
    public partial class modifLicVersion : Form
    {
        /// <summary>
        /// la fenêtre de consultation des prêts à partir de laquelle on souhaite modifier une licence de version. (permet par la suite de faire appel à la methode d'initialisation du résumé pour afficher les modification)
        /// </summary>
        private frmResume frmAppelant;
        /// <summary>
        /// licence de version qu'on souhaite modifier
        /// </summary>
        private Licence_version l;

        /// <summary>
        /// constructeur de la classe
        /// </summary>
        /// <param name="frmAppelant">la fenêtre de consultation des prêts à partir de laquelle on souhaite modifier une licence de version</param>
        /// <param name="id">identifiant de la licence de version qu'on souhaite modifier</param>
        public modifLicVersion(frmResume frmAppelant, int id)
        {
            this.frmAppelant = frmAppelant;
            InitializeComponent();

            Mysql m = new Mysql();
            Licence_version l = m.getLicenceVersion(id);
            this.l = l;

            /*AFFICHAGE DES INFORMATIONS DANS LE FORMULAIRE*/

            this.txtBoxNomLicVersion.Text = l.getNomVersion();
            this.lblNumLic.Text = l.getIdLicence().ToString();

            try
            {
                this.lblNumMatAssoc.Text = l.getMateriel().getIdMateriel().ToString();
            }
            catch (Exception ex)
            {

            }

        }

        /// <summary>
        /// fonction qui se déclenche lorsque l'utilisateur souhaite fermer la boite de dialogue. Les modifications dans ce cas là ne sont pas prises en compte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnul_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// fonction qui se déclenche lorsque l'utilisateur valide ses modifications. 
        /// Si tout est correctement rempli et que les modification ont été prises en compte alors la boite de dialogue est fermée est l'affichage du résumé des prêts est mis à jour (initialisé)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            Mysql m = new Mysql();

            Hashtable ht = new Hashtable();
            ht.Add("id", this.lblNumLic.Text);
            ht.Add("nom", this.txtBoxNomLicVersion.Text);

            try
            {
                m.updateLicenceVersion(ht);
                MessageBox.Show("la modification a réussie.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.frmAppelant.init(l.getPersonne().getIdPersonne());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

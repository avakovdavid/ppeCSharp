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
    /// classe qui remprésente le formulaire de saisie pour une licence de version
    /// </summary>
    public partial class frmNvlLicVersion : Form
    {
        /// <summary>
        /// le Form parent (fenêtre principale)
        /// </summary>
        private frmSaisie frmParent;

        /// <summary>
        /// constructeur du formulaire
        /// </summary>
        /// <param name="parent">Form parent (fenêtre principale)</param>
        public frmNvlLicVersion(frmSaisie parent)
        {
            InitializeComponent();
            this.frmParent = parent;
        }

        /// <summary>
        /// Getter du panel contenant le formulaire
        /// </summary>
        /// <returns>panel contenant le formulaire</returns>
        public Panel getPanel()
        {
            return this.panel;
        }

        /// <summary>
        /// Getter du numero de la licence de version attribué
        /// </summary>
        /// <returns>numero de la licence de version attribué (String)</returns>
        public String getNum()
        {
            return this.lblNumLicVersionAttribue.Text;
        }

        /// <summary>
        /// Getter du numero du matériel associé
        /// </summary>
        /// <returns>numero du matériel associé (String)</returns>
        public String getNumMatAssoc()
        {
            return this.txtBoxNumMatAssoc.Text;
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur clique sur le bouton de supression de la licence. 
        /// Si la licence a déjà été ajoutée alors dans cette fonction on va accepder à la base de données pour la supprimer, sinon on cache juste le formulaire 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSupp_Click(object sender, EventArgs e)
        {
            if (!this.lblNumLicVersionAttribue.Equals(""))
            {
                //nous allons devoir effectuer sa suppression dans la base de donnée : 
                Mysql m = new Mysql();
                try
                {
                    m.suppLicVersion(int.Parse(this.lblNumLicVersionAttribue.Text));
                    this.panel.Hide(); // on cache juste le formulaire 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                this.panel.Hide(); // on cache juste le formulaire 
            }
        }

        /// <summary>
        /// fonction executée lorsque l'utilisateur valide son formulaire. Elle effectue un enregistrement dans la base de données de cette licence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Mysql m = new Mysql();
            List<Personne> lesPers = m.getLesPersonne();

            //on remplis le tableau associatif avec les données : 
            Hashtable ht = new Hashtable();
            ht.Add("nom", this.txtBoxNomVersion.Text);
            ht.Add("NumMatAssoc", this.txtBoxNumMatAssoc.Text);
            ht.Add("id_pers", lesPers.ElementAt(this.frmParent.getListBox().SelectedIndex).getIdPersonne());

            //on essaye d'effectuer l'ajout de la licence de version
            try
            {
                String num = m.ajouterLicVersion(ht).ToString(); //on effectue la création dans la base de donnée (on va récupèrer l'identifiant attribué à la licence)
                this.lblNumLicVersionAttribue.Text = num; //on affiche l'identifiant attribué dans le label spécifé juste devant le formulaire de saisie
                this.btnAjouter.Hide(); //on cache le bouton ajouter pour pas ajouter deux fois la même licence
                MessageBox.Show("La licence de durée a bien été ajoutée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //on récupère la liste des Controls du formulaire qu'on vient de valider pour les désactiver (évider la modification du contenu)
                System.Windows.Forms.Control.ControlCollection lesControls = this.panel.Controls;

                //pour chaque controle on vérifie si ce n'est pas le bouton supprimé et si c'est pas le label qui affiche le numéro attribué puis si la condition est respectée on désactive le controle.
                for (int i = 0; i < lesControls.Count; i++)
                {
                    if (!lesControls[i].Name.Equals("btnSupp") && !lesControls[i].Name.Equals("lblNumLicVersionAttribue"))
                    {
                        lesControls[i].Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                //on va afficher la nature de l'erreur qui a causé l'échec de l'ajout
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

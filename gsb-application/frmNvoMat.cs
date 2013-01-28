using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;

namespace gsb_application
{
    public partial class frmNvoMat : Form
    {
        /// <summary>
        /// formulaire de saisie parent, c'est à dire celui où sera implémenté le formulaire pour un nouveau matériel
        /// </summary>
        private frmSaisie frmParent;

        /// <summary>
        /// Constructeur du formulaire pour un nouveau matériel
        /// </summary>
        /// <param name="parent">formulaire de saisie où sera implémenté le formulaire pour un nouveau matériel</param>
        public frmNvoMat(frmSaisie parent)
        {
            InitializeComponent();
            this.frmParent = parent;

            Mysql m = new Mysql();

            List<Marque> lesMarques = m.getLesMarque(); //la liste de toutes les marques
            List<Type_materiel> lesTypes = m.getLesTypeMateriel(); //la liste de tous les types


            // dans le code qui suit nous allons remplire les listes déroulantes pour les marques et les types
            var dataMarque = new List<String>();
            var dataType = new List<String>();
            
            for (int i = 0; i < lesMarques.Count; i++)
            {
                dataMarque.Add(lesMarques.ElementAt(i).getNomMarque());
            }
            for (int i = 0; i < lesTypes.Count; i++)
            {
                dataType.Add(lesTypes.ElementAt(i).getTypeMateriel());
            }

            this.cBoxMarque.DataSource = dataMarque;
            this.cBoxMarque.DropDownStyle = ComboBoxStyle.DropDownList; //rend la liste inmodifiable 

            this.cBoxType.DataSource = dataType;
            this.cBoxType.DropDownStyle = ComboBoxStyle.DropDownList; //rend la liste inmodifiable

        }

        /// <summary>
        /// Getter du panel dans lequel est placé le formulaire pour un nouveau matériel (ce getter est utilisé pour récupèrer le formulaire pour un nouveau matériel et l'implémenter dans le formulaire de saisie)
        /// </summary>
        /// <returns>panel qui contient le formulaire pour un nouveau matériel</returns>
        public Panel getPanel()
        {
            return this.panel;
        }

        /// <summary>
        /// Getter du numero du matériel attribué
        /// </summary>
        /// <returns>numero du matériel attribué (String)</returns>
        public String getNum()
        {
            return this.lblNumMatAttribue.Text;
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur clique sur le bouton de supression du matériel
        /// Si le matériel a déjà été ajouté alors dans cette fonction on va accepder à la base de données pour le supprimer, sinon on cache juste le formulaire 
        /// Les licences de version qui sont associées à ce matériel seront également supprimées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            //Si le label concernant le numéro attribué au matériel est vide :
            if (this.lblNumMatAttribue.Text.Equals(""))
            {
                this.panel.Hide(); // on cache juste le formulaire 
            }
            else
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce matériel ? Les licences associées à ce matériel seront également supprimées.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //nous allons devoir effectuer sa suppression dans la base de donnée : 
                    Mysql m = new Mysql();
                    try
                    {
                        m.suppMateriel(int.Parse(this.lblNumMatAttribue.Text));

                        //pour chaque formulaire de materiel
                        for (int i = 0; i < this.frmParent.getListeFrmNvoMat().Count; i++)
                        {
                            //si le formulaire a été validé (le numero attribué est ecrit)
                            if (!this.frmParent.getListeFrmNvoMat().ElementAt(i).getNum().Equals(""))
                            {
                                //pour chaque licence de duree
                                for (int j = 0; j < this.frmParent.getListeFrmNvlLicDuree().Count; j++)
                                {
                                    //si le formulaire a été validé (le numero attribué est ecrit) et si le numero du matériel est renseigné et est égale au numéro du materiel qu'on souhaite supprimer 
                                    if (!this.frmParent.getListeFrmNvlLicDuree().ElementAt(j).getNum().Equals("") && this.frmParent.getListeFrmNvlLicDuree().ElementAt(j).getNumMatAssoc().Equals(this.frmParent.getListeFrmNvoMat().ElementAt(i).getNum()))
                                    {
                                        //on effectue la suppression de cette licence.
                                        this.frmParent.getListeFrmNvlLicDuree().ElementAt(j).btnSupp_Click(sender,e);
                                    }
                                }
                                //pour chaque licence de vrsion
                                for (int k = 0; k < this.frmParent.getListeFrmNvlLicVersion().Count; k++)
                                {
                                    //si le formulaire a été validé (le numero attribué est ecrit) et si le numero du matériel est renseigné et est égale au numéro du materiel qu'on souhaite supprimer 
                                    if (!this.frmParent.getListeFrmNvlLicVersion().ElementAt(k).getNum().Equals("") && this.frmParent.getListeFrmNvlLicVersion().ElementAt(k).getNumMatAssoc().Equals(this.frmParent.getListeFrmNvoMat().ElementAt(i).getNum()))
                                    {
                                        //on effectue la suppression de cette licence.
                                        this.frmParent.getListeFrmNvlLicVersion().ElementAt(k).btnSupp_Click(sender, e);
                                    }
                                }
                            }
                        }
                        this.panel.Hide(); // on cache juste le formulaire 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        /// <summary>
        /// fonction executée lorsque l'utilisateur valide son formulaire. Elle effectue un enregistrement de ce matériel dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Mysql m = new Mysql();
            List<Personne> lesPers = m.getLesPersonne();

            //on remplis le tableau associatif avec les données : 
            Hashtable ht = new Hashtable();
            ht.Add("marque", this.cBoxMarque.SelectedValue);
            ht.Add("type", this.cBoxType.SelectedValue);
            ht.Add("date", this.dateTimePicker2.Value.Year + "/" + this.dateTimePicker2.Value.Month + "/" + this.dateTimePicker2.Value.Day);
            ht.Add("garantie", this.garantieMat.Value);
            ht.Add("id_pers", lesPers.ElementAt(this.frmParent.getListBox().SelectedIndex).getIdPersonne());
            
            //on essaye d'effectuer l'ajout du matériel
            try
            {
                String num = m.ajouterMateriel(ht).ToString(); //on effectue la création dans la base de donnée (on va récupèrer l'identifiant attribué au matériel)
                this.lblNumMatAttribue.Text = num; //on affiche l'identifiant attribué dans le label spécifé juste devant le formulaire de saisie
                this.btnAjouter.Hide(); //on cache le bouton ajouter pour pas ajouter deux fois le même matériel
                MessageBox.Show("Le matériel a bien été ajouté.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //on récupère la liste des Controls du formulaire qu'on vient de valider pour les désactiver (évider la modification du contenu)
                System.Windows.Forms.Control.ControlCollection lesControls = this.panel.Controls;

                //pour chaque controle on vérifie si ce n'est pas le bouton supprimé et si c'est pas le label qui affiche le numéro attribué puis si la condition est respectée on désactive le controle.
                for (int i = 0; i < lesControls.Count; i++)
                {
                    if (!lesControls[i].Name.Equals("btnSupp") && !lesControls[i].Name.Equals("lblNumMatAttribue"))
                    {
                        lesControls[i].Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                //on va affiché la nature de l'erreur qui a causé l'échec de l'ajout du nouveau matériel
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

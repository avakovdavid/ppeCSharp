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
    public partial class modifMateriel : Form
    {
        /// <summary>
        /// la fenêtre de consultation des prêts à partir de laquelle on souhaite modifier un matériel. (permet par la suite de faire appel à la methode d'initialisation du résumé pour afficher les modification)
        /// </summary>
        private frmResume frmAppelant;
        /// <summary>
        /// matériel qu'on souhaite modifier
        /// </summary>
        private Materiel materiel;

        /// <summary>
        /// constructeur de la classe
        /// </summary>
        /// <param name="frmAppelant">la fenêtre de consultation des prêts à partir de laquelle on souhaite modifier un matériel</param>
        /// <param name="id">identifiant du matériel qu'on souhaite modifier</param>
        public modifMateriel(frmResume frmAppelant, int id)
        {
            Mysql m = new Mysql();

            this.frmAppelant = frmAppelant;
            InitializeComponent();


            /*REMPLISAAGE DES LISTES DE MARQUES ET DES TYPES : */
            List<Marque> lesMarques = m.getLesMarque(); //la liste de toutes les marques
            List<Type_materiel> lesTypes = m.getLesTypeMateriel(); //la liste de tous les types

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
            this.cBoxType.DataSource = dataType;
            
            //on recupère le materiel qu'on souhaite modifier
            this.materiel = m.getMateriel(id);


            /*AFFICHAGE DES INFORMATIONS DANS LE FORMULAIRE*/
            this.lblNumMateriel.Text = this.materiel.getIdMateriel().ToString();
            this.cBoxMarque.SelectedItem = this.materiel.getMarque().getNomMarque();
            this.cBoxType.SelectedItem = this.materiel.getType().getTypeMateriel();
            this.dateMiseCirculation.Text = this.materiel.getDateCirculation().ToString();
            this.garantie.Value = this.materiel.getGarantie();
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
            ht.Add("id", this.lblNumMateriel.Text);
            ht.Add("marque", this.cBoxMarque.Text);
            ht.Add("type", this.cBoxType.Text);
            ht.Add("date", this.dateMiseCirculation.Value.Year + "/" + this.dateMiseCirculation.Value.Month + "/" + this.dateMiseCirculation.Value.Day);
            ht.Add("garantie", this.garantie.Value);

            try
            {
                m.updateMateriel(ht);
                MessageBox.Show("la modification a réussie.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.frmAppelant.init(this.materiel.getPersonne().getIdPersonne());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

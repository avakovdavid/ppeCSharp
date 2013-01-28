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
    /// classe qui remprésente le module de création d'un utilisateur
    /// </summary>
    public partial class Administration : Form
    {
        /// <summary>
        /// constructeur de la classe
        /// </summary>
        public Administration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fonction executée lorsque l'utilisateur souhaite choisi de créer un administrateur. 
        /// Elle permet d'aficher le formulaire pour la création d'un nouvel administrateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlEmploye.Hide();
            this.pnlAdmin.Show();
        }

        /// <summary>
        /// fonction executée lorsque l'utilisateur souhaite choisi de créer un employé. 
        /// Elle permet d'aficher le formulaire pour la création d'un nouvel eployé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnEmploye_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlAdmin.Hide();
            this.pnlEmploye.Show();
            this.pnlEmploye.Focus();
        }

        /// <summary>
        /// fonction executée lorsque l'utilisateur valide la création du nouvel employé. L'utilisateur est alors créé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("nom", this.tfdNomE.Text);
            ht.Add("prenom", this.tfdPrenomE.Text);
            ht.Add("email", this.tfdEmailE.Text);

            Mysql m = new Mysql();
            try
            {
                if (m.creerUtilisateur(ht, false))
                {
                    MessageBox.Show("L'utilisateur a bien été créé.","Succès",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        /// <summary>
        /// fonction executée lorsque l'utilisateur valide la création du nouvel administrateur. L'utilisateur est alors créé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerAdmin_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("nom", this.tfdNomA.Text);
            ht.Add("prenom", this.tfdPrenomA.Text);
            ht.Add("email", this.tfdEmailA.Text);
            ht.Add("login", this.tfdLoginA.Text);
            ht.Add("mdp", this.tfdMdpA.Text);
            ht.Add("mdpC", this.tfdMdpCA.Text);

            Mysql m = new Mysql();
            try
            {
                if (m.creerUtilisateur(ht, true))
                {
                    MessageBox.Show("L'utilisateur a bien été créé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

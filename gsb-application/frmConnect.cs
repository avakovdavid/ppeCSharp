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
    public partial class frmConnect : Form
    {
        /// <summary>
        /// classe qui modèlise la fenêtre de connection
        /// </summary>
        public frmConnect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur clique sur le bouton de connection ou la touche "Enter".
        /// Elle permet de vérifier si les identifiants entrés correspondent à ceux dans la base de données et prépare la fenêtre principale si la personne est identifiée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (this.tfdLogin.Text.Equals("") || this.tfdMdp.Text.Equals(""))
            {
                MessageBox.Show("Veuillez completer tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Mysql msql = new Mysql();
                    Personne p = msql.seConnecter(this.tfdLogin.Text, this.tfdMdp.Text);
                    if (p != null)
                    {
                        MessageBox.Show("Vous êtes maintenant connectés.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ((MainWindows)MdiParent).getSeConnecter().Visible = false;
                        ((MainWindows)MdiParent).getSeDeconnecter().Visible = true;
                        ((MainWindows)MdiParent).getLesPretsItem().Enabled = true;
                        ((MainWindows)MdiParent).getAdministration().Enabled = true;
                        ((MainWindows)MdiParent).getProfil().Enabled = true;
                        ((MainWindows)MdiParent).getStatistiques().Enabled = true;

                        ((MainWindows)MdiParent).getProfil().Text = p.getNomPersonne() + " " + p.getPrenomPersonne();

                        this.Close();

                        MainWindows.setPersConnect((Object)p);
                    }
                    else
                    {
                        MessageBox.Show("identifiants incorrectes.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        /// <summary>
        /// fonction qui est executée lorsque l'utilisateur appuie sur la touche.
        /// Si c'est la touche "Enter" alors on fait appel à la fonction de connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Return"))
            {
                this.btnConnexion_Click(sender, e);
            }
        }
    }
}
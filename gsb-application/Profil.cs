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
    /// Classe qui représente le module de changement de mot de passe
    /// </summary>
    public partial class Profil : Form
    {
        /// <summary>
        /// constructeur de la classe
        /// </summary>
        public Profil()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// fonction qui se déclenche lorsque l'utilisateur valide le formulaire. une modification dans la base de données est alors effectué.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Mysql m = new Mysql();
                Personne p = (Personne)MainWindows.getPersConnect();
                m.changerMdp(p, this.tfdMdp.Text, this.tfdNvoMdp.Text, this.tfdNvoMdpC.Text);
                MessageBox.Show("Votre mot de passe a bien été modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

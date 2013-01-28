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
    /// Classe qui représente la fenêtre principale de l'application
    /// </summary>
    public partial class MainWindows : Form
    {
        /// <summary>
        /// personne qui est connectée sur l'application en ce moment
        /// </summary>
        private static object persConnect = null;
        /// <summary>
        /// module profil de l'application
        /// </summary>
        private Form profil = null;
        /// <summary>
        /// module administration de l'application
        /// </summary>
        private Form administration = null;
        /// <summary>
        /// fenêtre de connection de l'application
        /// </summary>
        private Form frmConnect = null;
        /// <summary>
        /// fenêtre d'aide
        /// </summary>
        private Form aide = null;
        /// <summary>
        /// module de saisie d'un prêt
        /// </summary>
        private Form frmSaisie = null;
        /// <summary>
        /// module de statistiques sur l'application
        /// </summary>
        private Form statistiqueDeLapp = null;
        /// <summary>
        /// module de consultation des prêts
        /// </summary>
        private Form frmResume = null;
        /// <summary>
        /// module de statistiques sur les matériels
        /// </summary>
        private Form statistiqueMateriel = null;
        
        
        /// <summary>
        /// Constructeur de la classe 
        /// </summary>
        public MainWindows()
        {
            InitializeComponent();
            this.init();
        }

        /// <summary>
        /// fonction qui permet d'initialiser la fenêtre principale de l'application
        /// </summary>
        private void init()
        {
            if (this.frmConnect == null || !this.frmConnect.CanFocus)
            {
                //on crée la fenêtre de connexion et on l'affiche
                frmConnect = new frmConnect();
                this.AddOwnedForm(frmConnect);
                frmConnect.MdiParent = this;
                frmConnect.Show();
            }
            else
            {
                this.frmConnect.Focus();
            }

            // Pour désactiver le menu quand la personne n'est pas connectée 
            this.seConnecterToolStripMenuItem.Visible = true;
            this.seDeconnecterToolStripMenuItem.Visible = false;
            this.statistiqueToolStripMenuItem.Enabled = false;
            this.lesPrêtsToolStripMenuItem.Enabled = false;
            this.administrationToolStripMenuItem.Enabled = false;
            this.profilToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Getter pour la personne connectée actuellement sur l'application
        /// </summary>
        /// <returns>personne connectée actuellement sur l'application</returns>
        public static Object getPersConnect()
        {
            return (Personne)MainWindows.persConnect;
        }

        /// <summary>
        /// Setter pour la personne connectée (qui vient de se connecter
        /// </summary>
        /// <param name="p">personne qui vient de se connecter</param>
        public static void setPersConnect(Object p)
        {
            MainWindows.persConnect = p;
        }

        /// <summary>
        /// Getter de l'item "se deconnecter" du menu
        /// </summary>
        /// <returns>l'item "se deconnecter" du menu</returns>
        public ToolStripMenuItem getSeDeconnecter()
        {
            return this.seDeconnecterToolStripMenuItem;
        }

        /// <summary>
        /// Getter de l'item "se connecter" du menu
        /// </summary>
        /// <returns>l'item "se connecter" du menu</returns>
        public ToolStripMenuItem getSeConnecter()
        {
            return this.seConnecterToolStripMenuItem;
        }

        /// <summary>
        /// Getter de l'item "quiter" du menu
        /// </summary>
        /// <returns>l'item "quiter" du menu</returns>
        public ToolStripMenuItem getQuiter()
        {
            return this.quitterToolStripMenuItem;
        }

        /// <summary>
        /// Getter de l'item "administration" du menu
        /// </summary>
        /// <returns>l'item "administration" du menu</returns>
        public ToolStripMenuItem getAdministration()
        {
            return this.administrationToolStripMenuItem;
        }

        /// <summary>
        /// Getter de l'item "profil" du menu
        /// </summary>
        /// <returns>l'item "profil" du menu</returns>
        public ToolStripMenuItem getProfil()
        {
            return this.profilToolStripMenuItem;
        }

        /// <summary>
        /// Getter de l'item "consulter les prêts" du menu
        /// </summary>
        /// <returns>l'item "consulter les prêts" du menu</returns>
        public ToolStripMenuItem getLesPretsItem()
        {
            return this.lesPrêtsToolStripMenuItem;
        }

        /// <summary>
        /// Getter de l'item "statistiques" du menu
        /// </summary>
        /// <returns>l'item "sttistiques" du menu</returns>
        public ToolStripMenuItem getStatistiques()
        {
            return this.statistiqueToolStripMenuItem;
        }

        /// <summary>
        /// fonction qui permet d'appeller le module de création d'un nouvel utilisateur lorsqu'on clique dessus dans le menu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void créerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.administration == null || !this.administration.CanFocus)
            {
                administration = new Administration();
                this.AddOwnedForm(administration);
                administration.MdiParent = this;
                administration.Show();
            }
            else
            {
                this.administration.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet d'appeller le module de changement de mot de passe lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changerDeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.profil == null || !this.profil.CanFocus)
            {
                this.profil = new Profil();
                this.AddOwnedForm(profil);
                profil.MdiParent = this;
                profil.Show();
            }
            else
            {
                this.profil.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet de quiter l'application lorsqu'on clique sur l'iteme corespondante dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// fonction qui permet d'appeller le module de connection lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmConnect == null || !this.frmConnect.CanFocus)
            {
                frmConnect = new frmConnect();
                this.AddOwnedForm(frmConnect);
                frmConnect.MdiParent = this;
                frmConnect.Show();
            }
            else
            {
                this.frmConnect.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet de se déconnecter lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nbFenetres = this.MdiChildren.Count();
            for (int i = 0; i < nbFenetres; i++)
            {
                this.MdiChildren.ElementAt(0).Close();
            }

            getProfil().Text = "Profil";

            persConnect = null;
            this.init();
        }

        /// <summary>
        /// fonction qui permet d'appeller le module de statistiques de l'application lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.statistiqueDeLapp == null || !this.statistiqueDeLapp.CanFocus)
            {
                this.statistiqueDeLapp = new StatistiquesDeLapp();
                this.AddOwnedForm(statistiqueDeLapp);
                statistiqueDeLapp.MdiParent = this;
                statistiqueDeLapp.Show();
            }
            else
            {
                this.statistiqueDeLapp.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet d'appeller le module de saisie des prêts lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauPrêtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.frmSaisie == null || !this.frmSaisie.CanFocus)
            {
                this.frmSaisie = new frmSaisie();
                this.AddOwnedForm(frmSaisie);
                frmSaisie.MdiParent = this;
                frmSaisie.Show();
            }
            else
            {
                this.frmSaisie.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet d'appeller le module de consultation des prêts lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consulterLesPrêtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmResume == null || !this.frmResume.CanFocus)
            {
                this.frmResume = new frmResume();
                this.AddOwnedForm(frmResume);
                frmResume.MdiParent = this;
                frmResume.Show();
            }
            else
            {
                this.frmResume.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet d'appeller le manuel d'utilisation de l'application lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manuelDutilisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.aide == null || !this.aide.CanFocus)
            {
                this.aide = new Aide();
                this.AddOwnedForm(aide);
                aide.MdiParent = this;
                aide.Show();
            }
            else
            {
                this.aide.Focus();
            }
        }

        /// <summary>
        /// fonction qui permet d'afficher le module des statistiques sur les matériels lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistiqueDesMateriauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.statistiqueMateriel == null || !this.statistiqueMateriel.CanFocus)
            {
                this.statistiqueMateriel = new statistiqueMateriel();
                this.AddOwnedForm(statistiqueMateriel);
                statistiqueMateriel.MdiParent = this;
                statistiqueMateriel.Show();
            }
            else
            {
                this.statistiqueMateriel.Focus();
            }

        }

        /// <summary>
        /// fonction qui permet d'afficher le module des statistiques de l'application lorsqu'on clique dessus dans le munu ou à partir d'un racourci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void affToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.statistiqueDeLapp == null || !this.statistiqueDeLapp.CanFocus)
            {
                this.statistiqueDeLapp = new StatistiquesDeLapp();
                this.AddOwnedForm(statistiqueDeLapp);
                statistiqueDeLapp.MdiParent = this;
                statistiqueDeLapp.Show();
            }
            else
            {
                this.statistiqueDeLapp.Focus();
            }
        }

        /// <summary>
        /// fonction qui gère les racourcis clavier 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evenementClavier_KeyPress(object sender, KeyEventArgs e)
        {
            //afficher le manuel d'utilisation du programme
            if (e.KeyCode.ToString().Equals("F1"))
            {
                this.manuelDutilisationToolStripMenuItem_Click(sender, e);
            }

            //quitter le programme
            if (e.Control && e.KeyCode.ToString().Equals("Q"))
            {
                this.quitterToolStripMenuItem_Click(sender, e);
            }

            //ouvrir la fenêtre de connexion
            if (e.Control && e.KeyCode.ToString().Equals("L"))
            {
                if (persConnect == null)
                {
                    this.seConnecterToolStripMenuItem_Click(sender, e);
                }
            }

            //se déconnecter
            if (e.Control && e.KeyCode.ToString().Equals("O"))
            {
                if (persConnect != null)
                {
                    this.seDeconnecterToolStripMenuItem_Click(sender, e);
                }
            }

            //fermer la fenetre active dans le programme
            if (e.Control && e.KeyCode.ToString().Equals("W"))
            {
                if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
            }

            //afficher les statistiques matériels 
            if (e.Control && e.KeyCode.ToString().Equals("S"))
            {
                if (persConnect != null)
                {
                    this.statistiqueDesMateriauxToolStripMenuItem_Click(sender, e);
                }
            }

            //Modifier le mot de passe
            if (e.Control && e.KeyCode.ToString().Equals("P"))
            {
                if (persConnect != null)
                {
                    this.changerDeMotDePasseToolStripMenuItem_Click(sender, e);
                }
            }

            //Créer un nouvel utilisateur
            if (e.Control && e.KeyCode.ToString().Equals("U"))
            {
                if (persConnect != null)
                {
                    this.créerUnUtilisateurToolStripMenuItem_Click(sender, e);
                }
            }

            //ajouter un nouveau prêt
            if (e.Control && e.KeyCode.ToString().Equals("N"))
            {
                if (persConnect != null)
                {
                    this.nouveauPrêtToolStripMenuItem1_Click(sender, e);
                }
            }

            //consulter les prêts
            if (e.Control && e.KeyCode.ToString().Equals("K"))
            {
                if (persConnect != null)
                {
                    this.consulterLesPrêtsToolStripMenuItem_Click(sender, e);
                }
            }

            //consulter les statistiques de l'application 
            if (e.Alt && e.KeyCode.ToString().Equals("S"))
            {
                if (persConnect != null)
                {
                    this.statistiquesToolStripMenuItem_Click(sender, e);
                }
            } 
        }
    }
}

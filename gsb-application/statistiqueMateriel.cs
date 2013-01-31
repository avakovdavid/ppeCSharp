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
    /// Classe qui représente le module des statistiques sur les matériels
    /// </summary>
    public partial class statistiqueMateriel : Form
    {
        /// <summary>
        /// Constructeur du module des statistiques sur les matériels 
        /// </summary>
        public statistiqueMateriel()
        {
            InitializeComponent();

            Mysql m = new Mysql();
            List<Licence_duree> licence = new List<Licence_duree>();
            licence = m.getLesStatLicence();

            this.tableau2.Controls.Clear();

            Label lblTitre10 = new Label();
            lblTitre10.Text = "n° licence";
            this.tableau2.Controls.Add(lblTitre10);
            lblTitre10.Font = new Font(lblTitre10.Font, FontStyle.Bold);

            Label lblTitre11 = new Label();
            lblTitre11.Text = "Nom";
            this.tableau2.Controls.Add(lblTitre11);
            lblTitre11.Font = new Font(lblTitre11.Font, FontStyle.Bold);

            Label lblTitre12 = new Label();
            lblTitre12.Text = "Date de debut";
            this.tableau2.Controls.Add(lblTitre12);
            lblTitre12.Font = new Font(lblTitre12.Font, FontStyle.Bold);

            Label lblTitre13 = new Label();
            lblTitre13.Text = "Durée";
            this.tableau2.Controls.Add(lblTitre13);
            lblTitre13.Font = new Font(lblTitre13.Font, FontStyle.Bold);

            Label lblTitre14 = new Label();
            lblTitre14.Text = "n° matériel associé";
            this.tableau2.Controls.Add(lblTitre14);
            lblTitre14.Font = new Font(lblTitre14.Font, FontStyle.Bold);

            for (int l = 0; l < licence.Count; l++)
            {
                Label lbl10 = new Label();
                lbl10.Text = "" + licence.ElementAt(l).getIdLicence();
                this.tableau2.Controls.Add(lbl10);

                Label lbl11 = new Label();
                lbl11.Text = "" + licence.ElementAt(l).getNomVersion();
                this.tableau2.Controls.Add(lbl11);

                Label lbl12 = new Label();
                lbl12.Text = "" + licence.ElementAt(l).getDebutLicence();
                this.tableau2.Controls.Add(lbl12);

                Label lbl13 = new Label();
                lbl13.Text = "" + licence.ElementAt(l).getDureeLicence();
                this.tableau2.Controls.Add(lbl13);

                Label lbl14 = new Label();
                try
                {
                    lbl14.Text = "" + licence.ElementAt(l).getMateriel().getIdMateriel();
                }
                catch (Exception ex)
                {
                    lbl14.Text = "";
                }
                this.tableau2.Controls.Add(lbl14);
            }
            afficher();
        }

        /// <summary>
        /// fonction qui permet d'afficher (d'actualiser) le tableau tatistique des matériels 
        /// </summary>
        public void afficher()
        {
            Mysql m = new Mysql();
            List<Materiel> materiel = new List<Materiel>();
            materiel = m.getLesStatMateriel((int)this.anciennete.Value);

            this.tableau1.Controls.Clear();
            this.tableau1.Show();

            //si la requete a retourné au moins un résultat : 
            if (materiel.Count != 0)
            {
                /*ATTRIBUTION DES TITRES EN HAUT DE CHAQUE COLONNE : */
                Label lblTitre1 = new Label();
                lblTitre1.Text = "n° matériel";
                this.tableau1.Controls.Add(lblTitre1);
                lblTitre1.Font = new Font(lblTitre1.Font, FontStyle.Bold);

                Label lblTitre2 = new Label();
                lblTitre2.Text = "Date de mise en circulation";
                this.tableau1.Controls.Add(lblTitre2);
                lblTitre2.Font = new Font(lblTitre2.Font, FontStyle.Bold);

                Label lblTitre3 = new Label();
                lblTitre3.Text = "Garantie";
                this.tableau1.Controls.Add(lblTitre3);
                lblTitre3.Font = new Font(lblTitre3.Font, FontStyle.Bold);

                Label lblTitre4 = new Label();
                lblTitre4.Text = "Marque";
                this.tableau1.Controls.Add(lblTitre4);
                lblTitre4.Font = new Font(lblTitre4.Font, FontStyle.Bold);

                Label lblTitre5 = new Label();
                lblTitre5.Text = "Type";
                this.tableau1.Controls.Add(lblTitre5);
                lblTitre5.Font = new Font(lblTitre5.Font, FontStyle.Bold);

                /*POUR CHAQUE MATERIEL ON VA REMPLIR UNE LIGNE DANS LE TABLEAU*/
                for (int i = 0; i < materiel.Count; i++)
                {
                    Label lbl1 = new Label();
                    lbl1.Text = "" + materiel.ElementAt(i).getIdMateriel();
                    this.tableau1.Controls.Add(lbl1);

                    Label lbl2 = new Label();
                    lbl2.Text = "" + materiel.ElementAt(i).getDateCirculation();
                    this.tableau1.Controls.Add(lbl2);

                    Label lbl3 = new Label();
                    lbl3.Text = "" + materiel.ElementAt(i).getGarantie();
                    this.tableau1.Controls.Add(lbl3);

                    Label lbl4 = new Label();
                    lbl4.Text = "" + materiel.ElementAt(i).getMarque().getNomMarque();
                    this.tableau1.Controls.Add(lbl4);

                    Label lbl5 = new Label();
                    lbl5.Text = "" + materiel.ElementAt(i).getType().getTypeMateriel();
                    this.tableau1.Controls.Add(lbl5);
                }
            }
            else
            {   //sinon si aucun résultat n'est retourné par la requete on va cacher le tableau.
                this.tableau1.Hide();
            }
        }

        /// <summary>
        /// fonction qui est appellée à chaque fois que l'utilisateur change la valeur de l'ancienneté du matériel. 
        /// A partir de cette fonction on appelle la fonction affiche() qui va actualiser toutes les informations dans le tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anciennete_ValueChanged(object sender, EventArgs e)
        {
            afficher();
        }
    }
}

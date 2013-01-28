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
    public partial class statistiqueMateriel : Form
    {
        /// <summary>
        /// Constructeur du module des statistiques sur les matériels 
        /// </summary>
        public statistiqueMateriel()
        {
            InitializeComponent();
            
            Mysql m = new Mysql();
            List<Materiel> materiel = new List<Materiel>();
            materiel = m.getLesStatMateriel();

     
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

            List<Licence_duree> licence = new List<Licence_duree>();
            licence = m.getLesStatLicence();

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
                catch(Exception ex)
                {
                   lbl14.Text = "";
                }
                this.tableau2.Controls.Add(lbl14);
            }
        }
    }
}

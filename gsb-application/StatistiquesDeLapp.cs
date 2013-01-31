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
    /// classe qui représente le module concernant les statistiques de l'application 
    /// </summary>
    public partial class StatistiquesDeLapp : Form
    {
        /// <summary>
        /// constructeur de la classe
        /// </summary>
        public StatistiquesDeLapp()
        {
            InitializeComponent();
            Mysql m = new Mysql();
            
            Hashtable az = m.statDeLapp();

            label1.Text = "Actullement il y a "+az["total"]+" utilisateurs enregistré dont " + az["sont_admin"]+" sont administrateurs.";
            label2.Text = " Au total, il y a " + az["nb_materiel"] + " matériel(s) pour " + az["nb_pers"] + " personne(s).";
            label3.Text = " Au total, il y a " + az["nb_licenceD"] + " licence(s) de durée pour " + az["nb_pers_licenceD"] + " personne(s).";
            label4.Text = " Au total, il y a " + az["nb_licenceV"] + " licence(s) de version pour " + az["nb_pers_licenceV"] + " personne(s).";
        }
    }
}

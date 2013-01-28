using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise une marque
    /// </summary>
    class Marque
    {
        /// <summary>
        /// identifiant de la marque
        /// </summary>
        private int id_marque;
        /// <summary>
        /// nom de la marque
        /// </summary>
        private String nom_marque;

        /// <summary>
        /// Constructeur de la marque
        /// </summary>
        /// <param name="id">identifiant de la marque</param>
        /// <param name="nom">nom de la marque</param>
        public Marque(int id, String nom)
        {
            this.id_marque = id;
            this.nom_marque = nom;
        }

        /// <summary>
        /// Getter de l'identifiant de la marque
        /// </summary>
        /// <returns>identifiant de la marque</returns>
        public int getIdMarque()
        {
            return this.id_marque;
        }

        /// <summary>
        /// Getter du nom de la marque
        /// </summary>
        /// <returns>nom de la marque</returns>
        public String getNomMarque()
        {
            return this.nom_marque;
        }

        /// <summary>
        /// Setter du nom de la marque
        /// </summary>
        /// <param name="nom">nouveau nom de la marque</param>
        public void setNomMarque(String nom)
        {
            this.nom_marque = nom;
        }
    }
}

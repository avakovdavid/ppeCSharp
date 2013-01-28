using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise le type des personnes
    /// </summary>
    class Type_personne
    {
        /// <summary>
        /// identifiant du type de personne
        /// </summary>
        private int id_type_personne;
        /// <summary>
        /// nom du type de personne
        /// </summary>
        private String type_personne;

        /// <summary>
        /// Constructeur du type de personne
        /// </summary>
        /// <param name="id">identifiant du type de personne</param>
        /// <param name="type">nom du type de personne</param>
        public Type_personne(int id, String type)
        {
            this.id_type_personne = id;
            this.type_personne = type;
        }

        /// <summary>
        /// Getter de l'identifiant du type de personne
        /// </summary>
        /// <returns>identifiant du type de personne</returns>
        public int getIdTypePersonne()
        {
            return this.id_type_personne;
        }

        /// <summary>
        /// Getter du nom du type de personne
        /// </summary>
        /// <returns>nom du type de personne</returns>
        public String getTypePersonne()
        {
            return this.type_personne;
        }
    }
}

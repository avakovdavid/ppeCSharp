using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise le type des matériels
    /// </summary>
    class Type_materiel
    {
        /// <summary>
        /// identifiant du type de matériel
        /// </summary>
        private int id_type_materiel;
        /// <summary>
        /// nom du type de matériel
        /// </summary>
        private String type_materiel;

        /// <summary>
        /// Constructeur du type de matériel
        /// </summary>
        /// <param name="id">identifiant du type de matériel</param>
        /// <param name="type_materiel">nom du type de matériel</param>
        public Type_materiel(int id, String type_materiel)
        {
            this.id_type_materiel = id;
            this.type_materiel = type_materiel;
        }

        /// <summary>
        /// Getter de l'identifiant du type de matériel
        /// </summary>
        /// <returns>identifiant du type de matériel</returns>
        public int getIdTypeMateriel()
        {
            return this.id_type_materiel;
        }

        /// <summary>
        /// Getter du nom du type de matériel
        /// </summary>
        /// <returns>nom du type de matériel</returns>
        public String getTypeMateriel()
        {
            return this.type_materiel;
        }

        /// <summary>
        /// Setter du nom du type de matériel
        /// </summary>
        /// <param name="type">nouveu nom du type de matériel</param>
        public void setTypeMateriel(String type)
        {
            this.type_materiel = type;
        }
    }
}
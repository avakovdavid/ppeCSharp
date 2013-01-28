using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise les licences de version (hérite de la classe Licence)
    /// </summary>
    class Licence_version : Licence
    {
        /// <summary>
        /// nom de la licence
        /// </summary>
        private String nom_version;

        /// <summary>
        /// Premier constructeur de la licence de version (dans le cas où elle est associée à un matériel)
        /// </summary>
        /// <param name="id">identifiant de la licence</param>
        /// <param name="nom">nom de la licence</param>
        /// <param name="p">personne à qui la licence est prêtée</param>
        /// <param name="m">matériel auquel la licence est associée</param>
        public Licence_version(int id, String nom, Personne p, Materiel m): base(id, p, m)
        {
            this.nom_version = nom;
        }

        /// <summary>
        /// Deuxième constructeur de la licence de version (dans le cas où elle n'est associée à aucun matériel)
        /// </summary>
        /// <param name="id">identifiant de la licence</param>
        /// <param name="nom">nom de la licence</param>
        /// <param name="p">personne à qui la licence est prêtée</param>
        public Licence_version(int id, String nom, Personne p): base(id, p)
        {
            this.nom_version = nom;
        }
        
        /// <summary>
        /// Getter du nom de la licence
        /// </summary>
        /// <returns>nom de la licence</returns>
        public String getNomVersion()
        {
            return this.nom_version;
        }

    }
}

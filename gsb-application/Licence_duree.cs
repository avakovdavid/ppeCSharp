using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise les licences de durée (hérite de la classe Licence)
    /// </summary>
    class Licence_duree : Licence
    {
        /// <summary>
        /// nom de la licence 
        /// </summary>
        private String nom_version;
        /// <summary>
        /// date du début de la licence
        /// </summary>
        private DateTime debut_licence;
        /// <summary>
        /// durée de la licence (en années)
        /// </summary>
        private int duree_licence;

        /// <summary>
        /// Premier constructeur de la licence de durée (dans le cas où elle est associée à un matériel)
        /// </summary>
        /// <param name="id">identifiant de la licence</param>
        /// <param name="nom">nom de la licence</param>
        /// <param name="date_debut">date du début de la licence</param>
        /// <param name="duree">duree de la licence (en années)</param>
        /// <param name="p">personne à qui cette licence est prêtée</param>
        /// <param name="m">matériel au quelle cette licence est associée</param>
        public Licence_duree(int id, String nom, DateTime date_debut, int duree, Personne p, Materiel m): base(id,p,m)
        {
            this.nom_version = nom;
            this.debut_licence = date_debut;
            this.duree_licence = duree;
        }

        /// <summary>
        /// Deuxième constructeur de la licence de durée (dans le cas où elle n'est associée à aucun matériel)
        /// </summary>
        /// <param name="id">identifiant de la licence</param>
        /// <param name="nom">nom de la licence</param>
        /// <param name="date_debut">date du début de la licence</param>
        /// <param name="duree">duree de la licence (en années)</param>
        /// <param name="p">personne à qui cette licence est prêtée</param>
        public Licence_duree(int id, String nom, DateTime date_debut, int duree, Personne p): base(id,p)
        {
            this.nom_version = nom;
            this.debut_licence = date_debut;
            this.duree_licence = duree;
        }

        /// <summary>
        /// Getter du nom de la licence
        /// </summary>
        /// <returns>nom de la licence</returns>
        public String getNomVersion()
        {
            return this.nom_version;
        }

        /// <summary>
        /// Getter de la date du début de la licence
        /// </summary>
        /// <returns>date du début de la licence</returns>
        public DateTime getDebutLicence()
        {
            return this.debut_licence;
        }

        /// <summary>
        /// Getter de la durée de la licence
        /// </summary>
        /// <returns>durée de la licence</returns>
        public int getDureeLicence()
        {
            return this.duree_licence;
        }
    }
}

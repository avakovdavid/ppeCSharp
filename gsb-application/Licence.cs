using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modélise les licences. (il y a deux types de licences)
    /// </summary>
    class Licence
    {
        /// <summary>
        /// L'identifiant de la licence
        /// </summary>
        private int id_licence;
        /// <summary>
        /// La personne qui possède cette licence
        /// </summary>
        private Personne personne;
        /// <summary>
        /// Le matériel associé à cette licence
        /// </summary>
        private Materiel materiel;

        /// <summary>
        /// Premier constructeur de Licence
        /// </summary>
        /// <param name="id">identifiant de la licence</param>
        /// <param name="p">personne qui possède la licence</param>
        /// <param name="m">matériel associé à la licence</param>
        public Licence(int id, Personne p, Materiel m)
        {
            this.id_licence = id;
            this.personne = p;
            this.materiel = m;
        }

        /// <summary>
        /// Deuxième constructeur de Licence
        /// </summary>
        /// <param name="id">identifiant de la licence</param>
        /// <param name="p">personne qui possède la licence</param>
        public Licence(int id, Personne p)
        {
            this.id_licence = id;
            this.personne = p;
        }

        /// <summary>
        /// Getter de l'identifiant de la licence
        /// </summary>
        /// <returns>identifiant de la licence</returns>
        public int getIdLicence()
        {
            return this.id_licence;
        }

        /// <summary>
        /// Getter de la personne qui possède la licence
        /// </summary>
        /// <returns>personne qui possède la licence</returns>
        public Personne getPersonne()
        {
            return this.personne;
        }

        /// <summary>
        /// Getter du matériel associé à la licence
        /// </summary>
        /// <returns>matériel associé à la licence</returns>
        public Materiel getMateriel()
        {
            //Si la licence est associée à un matériel : 
            if (this.materiel != null)
            {
                return this.materiel;
            }
            //Sinon la licence n'est associée à aucun matériel, une exception est levée : 
            else
            {
                throw new Exception("Pas de matériel associé pour cette licence.");
            }
        }
    }
}

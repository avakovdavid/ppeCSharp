using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise un matériel
    /// </summary>
    class Materiel
    {
        /// <summary>
        /// identifiant du matériel
        /// </summary>
        private int id_materiel;
        /// <summary>
        /// date de mise en circulation du matériel
        /// </summary>
        private DateTime date_circulation;
        /// <summary>
        /// nombre d'années de garantie du matériel
        /// </summary>
        private int garantie;
        /// <summary>
        /// personne à qui ce matériel est prêté
        /// </summary>
        private Personne personne;
        /// <summary>
        /// marque du matériel
        /// </summary>
        private Marque marque;
        /// <summary>
        /// type du matériel
        /// </summary>
        private Type_materiel type;

        /// <summary>
        /// Constructeur du matériel
        /// </summary>
        /// <param name="id">identifiant du matériel</param>
        /// <param name="date_circulation">date de mise en circulation du matériel</param>
        /// <param name="garantie">nombre d'années de garantie du matériel</param>
        /// <param name="p">personne à qui ce matériel est prêté</param>
        /// <param name="m">marque du matériel</param>
        /// <param name="t">type du matériel</param>
        public Materiel(int id, DateTime date_circulation, int garantie, Personne p, Marque m, Type_materiel t)
        {
            this.id_materiel = id;
            this.date_circulation = date_circulation;
            this.garantie = garantie;
            this.personne = p;
            this.marque = m;
            this.type = t;
        }

        /// <summary>
        /// Getter de l'indentifiant du matériel
        /// </summary>
        /// <returns>identifiant du matériel</returns>
        public int getIdMateriel()
        {
            return this.id_materiel;
        }

        /// <summary>
        /// Getter de la date de mise en circulation du matériel
        /// </summary>
        /// <returns>date de mise en circulation du matériel</returns>
        public DateTime getDateCirculation()
        {
            return this.date_circulation;
        }

        /// <summary>
        /// Getter du nombre d'années de garantie du matériel
        /// </summary>
        /// <returns>nombre d'années de garantie du matériel</returns>
        public int getGarantie()
        {
            return this.garantie;
        }

        /// <summary>
        /// Getter de la personne à qui ce matériel est prêté
        /// </summary>
        /// <returns>personne à qui ce matériel est prêté</returns>
        public Personne getPersonne()
        {
            return this.personne;
        }

        /// <summary>
        /// Getter de la marque du matériel
        /// </summary>
        /// <returns>marque du matériel</returns>
        public Marque getMarque()
        {
            return this.marque;
        }

        /// <summary>
        /// Getter du type du matériel
        /// </summary>
        /// <returns>type du matériel</returns>
        public Type_materiel getType()
        {
            return this.type;
        }

        /// <summary>
        /// Setter de la date de mise en circulation du matériel
        /// </summary>
        /// <param name="dateCirculation">nouvelle date de mise en circulation du matériel</param>
        public void setDateCirculation(DateTime dateCirculation)
        {
            this.date_circulation = dateCirculation;
        }

        /// <summary>
        /// Setter du nombre d'années de garantie du matériel
        /// </summary>
        /// <param name="garantie">nouveau nombre d'années de garantie du matériel</param>
        public void setGarantie(int garantie)
        {
            this.garantie = garantie;
        }

        /// <summary>
        /// Setter du type du matériel
        /// </summary>
        /// <param name="type">nouveau type du matériel</param>
        public void setType(Type_materiel type)
        {
            this.type = type;
        }
    }
}

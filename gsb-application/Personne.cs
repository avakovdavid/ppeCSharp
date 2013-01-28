using System;
using System.Text;
using System.Security.Cryptography;

namespace gsb_application
{
    /// <summary>
    /// Classe qui modèlise une personne
    /// </summary>
    class Personne
    {
        /// <summary>
        /// identifiant de la personne
        /// </summary>
        private int id_personne;
        /// <summary>
        /// nom de la personne
        /// </summary>
        private String nom_personne;
        /// <summary>
        /// prénom de la personne
        /// </summary>
        private String prenom_personne;
        /// <summary>
        /// mot de passe de la personne (crypté avec MD5)
        /// </summary>
        private String mdp_personne;
        /// <summary>
        /// login de la personne
        /// </summary>
        private String login_personne;
        /// <summary>
        /// adresse mail de la personne
        /// </summary>
        private String mail_personne;
        /// <summary>
        /// la personne est-elle administrateur ? <c>0</c> : non <c>1</c> : oui
        /// </summary>
        private int administrateur;
        /// <summary>
        /// le type de la personne
        /// </summary>
        private Type_personne type_personne;

        /// <summary>
        /// Constructeur de la personne
        /// </summary>
        /// <param name="id">identifiant de la personne</param>
        /// <param name="nom">nom de la personne</param>
        /// <param name="prenom">prenom de la personne</param>
        /// <param name="mdp">mot de passe de la personne (crypté avec MD5)</param>
        /// <param name="login">login de la personne</param>
        /// <param name="mail">adresse mail de la personne</param>
        /// <param name="admin">la personne est-elle administrateur ? <c>0</c> : non <c>1</c> : oui</param>
        /// <param name="type">type de la personne</param>
        public Personne(int id, String nom, String prenom, String mdp, String login, String mail, int admin, Type_personne type)
        {
            this.id_personne = id;
            this.nom_personne = nom;
            this.prenom_personne = prenom;
            this.mdp_personne = mdp;
            this.login_personne = login;
            this.mail_personne = mail;
            this.administrateur = admin;
            this.type_personne = type;
        }

        /// <summary>
        /// Getter de l'identifiant de la personne
        /// </summary>
        /// <returns>identifiant de la personne</returns>
        public int getIdPersonne()
        {
            return this.id_personne;
        }

        /// <summary>
        /// Getter du nom de la personne
        /// </summary>
        /// <returns>nom de la personne</returns>
        public String getNomPersonne()
        {
            return this.nom_personne;
        }

        /// <summary>
        /// Getter du prénom de la personne 
        /// </summary>
        /// <returns>prénom de la personne</returns>
        public String getPrenomPersonne()
        {
            return this.prenom_personne;
        }

        /// <summary>
        /// Getter du mot de passe de la personne
        /// </summary>
        /// <returns>mot de passe de la personne (crypté avec MD5)</returns>
        public String getMdpPersonne()
        {
            return this.mdp_personne;
        }

        /// <summary>
        /// Getter du login de la personne
        /// </summary>
        /// <returns>login de la personne</returns>
        public String getLoginPersonne()
        {
            return this.login_personne;
        }

        /// <summary>
        /// Getter de l'adresse mail de la personne
        /// </summary>
        /// <returns>adresse mail de la personne</returns>
        public String getMailPersonne()
        {
            return this.mail_personne;
        }

        /// <summary>
        /// Getter de la valeur indiquand si la personne est un administrateur ou pas. 
        /// </summary>
        /// <returns><c>0</c> : non <c>1</c> : oui</returns>
        public int getAdministrateur()
        {
            return this.administrateur;
        }

        /// <summary>
        /// Getter du type de la personne
        /// </summary>
        /// <returns>type de la personne</returns>
        public Type_personne getTypePersonne()
        {
            return this.type_personne;
        }

        /// <summary>
        /// Setter du mot de passe de la personne
        /// </summary>
        /// <param name="mdp">nouveau mot de passe de la personne (crypté avec MD5)</param>
        public void setMdpPersonne(String mdp)
        {
            this.mdp_personne = mdp;
        }

        /// <summary>
        /// Fonction qui permet de crypter une chaine de caractères avec MD5
        /// </summary>
        /// <param name="strText">chaine de caractères à crypter</param>
        /// <returns>chaine cryptée de 32 caractères</returns>
        public string toMD5(string strText)
        {
            Byte[] buffer;
            buffer = Encoding.Default.GetBytes(strText);
            try
            {
                MD5CryptoServiceProvider check = new MD5CryptoServiceProvider();
                Byte[] somme;
                somme = check.ComputeHash(buffer);
                string ret = "";

                foreach (byte a in somme)
                {
                    if (a < 16) ret += "0" + a.ToString("X");
                    else ret += a.ToString("X");
                }
                return ret.ToLower();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

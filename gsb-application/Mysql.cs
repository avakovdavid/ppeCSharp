using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Collections;

namespace gsb_application
{
    /// <summary>
    /// Classe qui représente la connexion à la base de données (permet la communication entre l'application et la base de données)
    /// </summary>
    class Mysql
    {
        /// <summary>
        /// La chaine de connexion à la base de données
        /// </summary>
        private String connectionString;
        /// <summary>
        /// représente la connexion à la base de données mysql
        /// </summary>
        private MySqlConnection connexion;

        /// <summary>
        /// Constructeur de la connexion
        /// </summary>
        public Mysql()
        { 
            try
            {

                //this.connectionString = "Server=instance34367.db.xeround.com; Port=16301; Database=test; Uid=david; Pwd=test;"; //hébérgé marche
                
                //this.connectionString = "Server=mysql11.000webhost.com;Database=a5300961_gsb;Uid=a5300961_david;Pwd=abc123;"; //hébérgé
                //this.connectionString = "Server=172.17.199.235;Database=test;Uid=root;Pwd=test;"; //local
                
                this.connectionString = ConfigurationManager.ConnectionStrings["bdd"].ConnectionString;
                this.connexion = new MySqlConnection(this.connectionString);
                connexion.Open();
            }
            catch (NullReferenceException e)
            {
                throw new Exception("Impossible de se connecter à la base de données.");
            }
        }

        /// <summary>
        /// Getter de tous les types de personne 
        /// </summary>
        /// <returns>liste des types de personne</returns>
        public List<Type_personne> getLesTypePersonne()
        {
            List<Type_personne> lesTypePersonne = new List<Type_personne>();
            int i = 0;
            String req = "SELECT * FROM TYPE_PERSONNE;";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lesTypePersonne.Add(new Type_personne(int.Parse(reader[0].ToString()), reader[1].ToString()));
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesTypePersonne;
        }

        /// <summary>
        /// Getter de toutes les personnes
        /// </summary>
        /// <returns>liste de toutes les personnes</returns>
        public List<Personne> getLesPersonne()
        {
            List<Personne> lesPersonne = new List<Personne>();
            List<Type_personne> lesTypePersonne = this.getLesTypePersonne();
            
            int i = 0;
            String req = "SELECT * FROM PERSONNE;";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Type_personne leType = lesTypePersonne.Find(type => type.getIdTypePersonne() == int.Parse(reader[7].ToString()));

                lesPersonne.Add(new Personne(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()), leType));
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesPersonne;
        }

        /// <summary>
        /// Getter de tous les types de matériel
        /// </summary>
        /// <returns>liste de tous les types de matériel</returns>
        public List<Type_materiel> getLesTypeMateriel()
        {
            List<Type_materiel> lesTypeMateriel = new List<Type_materiel>();
            int i = 0;
            String req = "SELECT * FROM TYPE_MATERIEL;";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lesTypeMateriel.Add(new Type_materiel(int.Parse(reader[0].ToString()), reader[1].ToString()));
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesTypeMateriel;
        }

        /// <summary>
        /// Getter de toutes les marques
        /// </summary>
        /// <returns>liste de toutes les marques</returns>
        public List<Marque> getLesMarque()
        {
            List<Marque> lesMarque= new List<Marque>();
            int i = 0;
            String req = "SELECT * FROM MARQUE;";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lesMarque.Add(new Marque(int.Parse(reader[0].ToString()), reader[1].ToString()));
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesMarque;
        }

        /// <summary>
        /// Getter de tous les matériels
        /// </summary>
        /// <returns>liste de tous les matériels</returns>
        public List<Materiel> getLesMateriel()
        {
            List<Materiel> lesMateriel = new List<Materiel>();
            List<Marque> lesMarque = this.getLesMarque();
            List<Type_materiel> lesTypeMateriel = this.getLesTypeMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM MATERIEL;";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));
                Marque marque = lesMarque.Find(m => m.getIdMarque() == int.Parse(reader[4].ToString()));
                Type_materiel type = lesTypeMateriel.Find(t => t.getIdTypeMateriel() == int.Parse(reader[5].ToString()));

                lesMateriel.Add(new Materiel(int.Parse(reader[0].ToString()), DateTime.Parse(reader[1].ToString()), int.Parse(reader[2].ToString()), personne, marque, type));
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesMateriel;
        }

        /// <summary>
        /// Getter de tous les matériels concernant une seule personne
        /// </summary>
        /// <param name="idPersonne">identifiant de la personne dont on veut avoir les matériel qu'elle a emprunté</param>
        /// <returns>liste des matériels</returns>
        public List<Materiel> getLesMateriel(int idPersonne)
        {
            List<Materiel> lesMateriel = new List<Materiel>();
            List<Marque> lesMarque = this.getLesMarque();
            List<Type_materiel> lesTypeMateriel = this.getLesTypeMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM MATERIEL WHERE id_personne=" + idPersonne + ";";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));
                Marque marque = lesMarque.Find(m => m.getIdMarque() == int.Parse(reader[4].ToString()));
                Type_materiel type = lesTypeMateriel.Find(t => t.getIdTypeMateriel() == int.Parse(reader[5].ToString()));

                lesMateriel.Add(new Materiel(int.Parse(reader[0].ToString()), DateTime.Parse(reader[1].ToString()), int.Parse(reader[2].ToString()), personne, marque, type));
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesMateriel;
        }

        /// <summary>
        /// Getter de toutes les licences de durée
        /// </summary>
        /// <returns>liste de toutes les licences de durée</returns>
        public List<Licence_duree> getLesLicenceDuree()
        {
            List<Licence_duree> lesLicenceDuree = new List<Licence_duree>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_DUREE";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[4].ToString()));
                
                if (!reader[5].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[5].ToString()));
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne, materiel));
                }
                else
                {
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceDuree;
        }
        
        /// <summary>
        /// Getter de toutes les licences de durée concernant une seule personne
        /// </summary>
        /// <param name="id">identifiant de la personne dont on souhaite connaître les licences de durée qu'elle a emprunté</param>
        /// <returns>liste des licences de durée</returns>
        public List<Licence_duree> getLesLicenceDuree(int id)
        {
            List<Licence_duree> lesLicenceDuree = new List<Licence_duree>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_DUREE WHERE id_personne=" + id;
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[4].ToString()));

                if (!reader[5].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[5].ToString()));
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne, materiel));
                }
                else
                {
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceDuree;
        }

        /// <summary>
        /// Getter de toutes les licences de durée concernant une personne et qui sont associées à un matériel
        /// </summary>
        /// <param name="id">identifiant de la personne dont on souhaite connaître les licences de durée qu'elle a emprunté</param>
        /// <param name="idMat">identifiant du matériel pour lequel on souhaite avoir les licences de durée associées</param>
        /// <returns>liste des licences de durée</returns>
        public List<Licence_duree> getLesLicenceDuree(int id, int idMat)
        {
            List<Licence_duree> lesLicenceDuree = new List<Licence_duree>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_DUREE WHERE id_personne=" + id + " AND id_materiel=" + idMat;
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[4].ToString()));

                if (!reader[5].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[5].ToString()));
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne, materiel));
                }
                else
                {
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceDuree;
        }

        /// <summary>
        /// Fonction qui permet de récupèrer depuis la base de données la licence de durée dont l'identifiant est passé en paramètres
        /// </summary>
        /// <param name="id">identifiant de la licence de durée qu'on souhaite avoir</param>
        /// <returns>licence de durée</returns>
        public Licence_duree getLicenceDuree(int id)
        {
            Licence_duree licenceDuree;
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_DUREE WHERE id_licence_duree=" + id;
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[4].ToString()));

                if (!reader[5].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[5].ToString()));
                    licenceDuree = new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne, materiel);
                }
                else
                {
                    licenceDuree = new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne);
                }
                i++;
                return licenceDuree;
            }
            // fermeture reader
            reader.Close();
            
            throw new Exception("Pas de licence avec l'identifiant : " + id);            
        }

        /// <summary>
        /// fonction qui permet de mettre à jour une licence de durée dans la base de données.
        /// </summary>
        /// <param name="ht">tableau associatif qui contient toutes les données nécessaires</param>
        public void updateLicenceDuree(Hashtable ht)
        {
            //on verifie que tous les champs sont remplis
            if (ht["nom"].Equals(""))
            {
                throw new Exception("Tous les champs doivent être remplis.");
            }
            else
            {
                try
                {
                    String req = "UPDATE LICENCE_DUREE SET nom_version='"+ht["nom"]+"', debut_licence='"+ht["date"]+"', duree_licence="+ht["duree"]+" WHERE id_licence_duree="+ht["id"];

                    MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                    IDataReader reader = sqlCommand.ExecuteReader();
                }
                catch(Exception ex)
                {
                    throw new Exception("Les modification n'ont pas pu être appliquées, veuillez recommencer.");
                }
            }
        }

        /// <summary>
        /// Getter de toutes les licences de version
        /// </summary>
        /// <returns>liste de toutes les licences de version</returns>
        public List<Licence_version> getLesLicenceVersion()
        {
            List<Licence_version> lesLicenceVersion = new List<Licence_version>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_VERSION";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));

                if (!reader[2].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[2].ToString()));
                    lesLicenceVersion.Add(new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne, materiel));
                }
                else
                {
                    lesLicenceVersion.Add(new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceVersion;
        }

        /// <summary>
        /// Getter de toutes les licences de version concernant une seule personne
        /// </summary>
        /// <param name="id">identifiant de la personne dont on souhaite connaître les licences de version qu'elle a emprunté</param>
        /// <returns>liste des licences de version</returns>
        public List<Licence_version> getLesLicenceVersion(int id)
        {
            List<Licence_version> lesLicenceVersion = new List<Licence_version>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_VERSION WHERE id_personne=" + id;
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));

                if (!reader[2].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[2].ToString()));
                    lesLicenceVersion.Add(new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne, materiel));
                }
                else
                {
                    lesLicenceVersion.Add(new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceVersion;
        }

        /// <summary>
        /// Getter de toutes les licences de version concernant une personne et qui sont associées à un matériel
        /// </summary>
        /// <param name="id">identifiant de la personne dont on souhaite connaître les licences de version qu'elle a emprunté</param>
        /// <param name="idMat">identifiant du matériel pour lequel on souhaite avoir les licences de version associées</param>
        /// <returns>liste des licences de version</returns>
        public List<Licence_version> getLesLicenceVersion(int id, int idMat)
        {
            List<Licence_version> lesLicenceVersion = new List<Licence_version>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_VERSION WHERE id_personne=" + id + " AND id_materiel=" + idMat;
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));

                if (!reader[2].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[2].ToString()));
                    lesLicenceVersion.Add(new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne, materiel));
                }
                else
                {
                    lesLicenceVersion.Add(new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceVersion;
        }

        /// <summary>
        /// Fonction qui permet de récupèrer depuis la base de données la licence de version dont l'identifiant est passé en paramètres
        /// </summary>
        /// <param name="id">identifiant de la licence de version qu'on souhaite avoir</param>
        /// <returns>licence de version</returns>
        public Licence_version getLicenceVersion(int id)
        {
            Licence_version licenceVersion;
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_VERSION WHERE id_licence_version=" + id;
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));

                if (!reader[2].ToString().Equals(""))
                {
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[2].ToString()));
                    licenceVersion = new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne, materiel);
                }
                else
                {
                    licenceVersion = new Licence_version(int.Parse(reader[0].ToString()), reader[1].ToString(), personne);
                }
                i++;
                return licenceVersion;                
            }
            // fermeture reader
            reader.Close();

            throw new Exception("Pas de licence avec l'identifiant : " + id);    
        }

        /// <summary>
        /// fonction qui permet de mettre à jour une licence de version dans la base de données.
        /// </summary>
        /// <param name="ht">tableau associatif qui contient toutes les données nécessaires</param>
        public void updateLicenceVersion(Hashtable ht)
        {
            //on verifie que tous les champs sont remplis
            if (ht["nom"].Equals(""))
            {
                throw new Exception("Tous les champs doivent être remplis.");
            }
            else
            {
                try
                {
                    String req = "UPDATE LICENCE_VERSION SET nom_version='" + ht["nom"] + "' WHERE id_licence_version=" + ht["id"];

                    MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                    IDataReader reader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw new Exception("Les modification n'ont pas pu être appliquées, veuillez recommencer.");
                }
            }
        }

        /// <summary>
        /// Getter des matériels qui ont plus de 5 ans d'ancienneté 
        /// </summary>
        /// <returns>liste des matériels de plus de 5 ans d'ancienneté</returns>
        public List<Materiel> getLesStatMateriel()
        {
            List<Materiel> lesMateriel = new List<Materiel>();

            List<Marque> lesMarque = this.getLesMarque();
            List<Type_materiel> lesTypeMateriel = this.getLesTypeMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();


            int i = 0;
            String req = "SELECT *, nom_marque FROM MATERIEL, MARQUE, TYPE_MATERIEL WHERE DATEDIFF( NOW(),date_circulation)  >= 1825 GROUP BY id_materiel";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[3].ToString()));
                Marque marque = lesMarque.Find(m => m.getIdMarque() == int.Parse(reader[4].ToString()));
                Type_materiel type = lesTypeMateriel.Find(t => t.getIdTypeMateriel() == int.Parse(reader[5].ToString()));
                Materiel mat = new Materiel(int.Parse(reader[0].ToString()), DateTime.Parse(reader[1].ToString()), int.Parse(reader[2].ToString()), personne, marque, type);

                lesMateriel.Add(mat);
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesMateriel;
        }

        /// <summary>
        /// Getter des licences qui expirent dans moins de 15 jours
        /// </summary>
        /// <returns>liste des licences qui expirent dans moins de 15 jours</returns>
        public List<Licence_duree> getLesStatLicence()
        {
            List<Licence_duree> lesLicenceDuree = new List<Licence_duree>();
            List<Materiel> lesMateriel = this.getLesMateriel();
            List<Personne> lesPersonne = this.getLesPersonne();

            int i = 0;
            String req = "SELECT * FROM LICENCE_DUREE WHERE DATEDIFF(NOW() , debut_licence)  >= (duree_licence*365)-15";
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);

            IDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Personne personne = lesPersonne.Find(p => p.getIdPersonne() == int.Parse(reader[4].ToString()));
                
                if (!reader[5].ToString().Equals(""))
                {
                    //on entre ici lorsqu'il y a un matériel associé à la licence
                    Materiel materiel = lesMateriel.Find(m => m.getIdMateriel() == int.Parse(reader[5].ToString()));
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne, materiel));
                }
                else
                {
                    //on entre ici s'il n'y a pas de matériels associés à la licence
                    lesLicenceDuree.Add(new Licence_duree(int.Parse(reader[0].ToString()), reader[1].ToString(), DateTime.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), personne));
                }
                i++;
            }
            // fermeture reader
            reader.Close();
            return lesLicenceDuree;
        }

        /// <summary>
        /// Fonction de connexion de l'utilisateur. Elle vérifie si le login et le mot de passe sont valides et que la personne a le droit de se connecter à l'application
        /// </summary>
        /// <param name="login">login de la personne</param>
        /// <param name="mdp">mot de passe de la personne (non crypté, le cryptage se fait lors de la vérification)</param>
        /// <returns>objet de type Personne qui vient de se connecter</returns>
        public Personne seConnecter(String login, String mdp)
        {
            Personne p = null;
            List<Type_personne> lesTypePersonne = this.getLesTypePersonne();

            String req = "SELECT * FROM PERSONNE WHERE administrateur=1 AND login_personne='" + login + "' AND mdp_personne='" + this.toMD5(mdp) + "';";

            int i = 0;
            
            MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
            IDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Type_personne leType = lesTypePersonne.Find(type => type.getIdTypePersonne() == int.Parse(reader[7].ToString()));

                p = new Personne(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()), leType);
                i++;
            }
            reader.Close();
            
            //si la variable p n'a pas été affectée (donc tjr null) alors aucun utilisateur n'a été trouvé dans la base avec ces identifiants
            if (p == null)
            {
                throw new Exception("Les identifiants sont incorrectes, veuillez recommencer s'il vous plait.");
            }
            else
            {
                return p;
            }
        }

        /// <summary>
        /// Fonction qui permet de créer un nouvel utilisateur (que ça soit administrateur ou employé normal)
        /// </summary>
        /// <param name="ht">tableau associatif qui contient toutes les données pour la création de l'utilisateur.
        /// Pour un administrateur : 
        /// <code>
        /// ht["nom"]; ht["prenom"]; ht["email"]; ht["login"]; ht["mdp"]; ht["mdpC"];
        /// </code>
        /// Pour un employé : 
        /// <code>
        /// ht["nom"].Equals("") || ht["prenom"].Equals("") || ht["email"]
        /// </code>
        /// </param>
        /// <param name="admin">Est-ce un administrateur ? <c>true</c> : oui <c>false</c> : non</param>
        /// <returns><c>true</c> si la création a réussi ou une exception si la création a échoué</returns>
        public Boolean creerUtilisateur(Hashtable ht, Boolean admin)
        {
            if (admin) //si c'est pour la création d'un compte admin
            {
                if (ht["nom"].Equals("") || ht["prenom"].Equals("") || ht["email"].Equals("") || ht["login"].Equals("") || ht["mdp"].Equals("") || ht["mdpC"].Equals(""))
                {
                    throw new Exception("Tous les champs doivent être remplis.");
                }
                else
                {
                    //verification que le mail n'existe pas déjà dans la base :
                    String req = "SELECT * FROM PERSONNE WHERE mail_personne='" + ht["email"] + "';";

                    int i = 0;

                    MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                    IDataReader reader = sqlCommand.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        i++;
                    }
                    reader.Close();

                    if (i == 1)
                    {
                        throw new Exception("Cette adresse mail a déjà été utilisée.");
                    }
                    else
                    {
                        //verifier que le login n'existe pas déjà dans la base
                        String req1 = "SELECT * FROM PERSONNE WHERE login_personne='" + ht["login"] + "';";

                        int j = 0;

                        sqlCommand = new MySqlCommand(req1, connexion);
                        reader = sqlCommand.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            j++;
                        }
                        reader.Close();

                        if (j == 1)
                        {
                            throw new Exception("Ce login a déjà été utilisé.");
                        }
                        else
                        {
                            //vérification que la confirmation du mot de passe est correcte :
                            if (ht["mdp"].Equals(ht["mdpC"]))
                            {
                                String req2 = "INSERT INTO PERSONNE(id_personne,nom_personne,prenom_personne,mail_personne,login_personne,mdp_personne,administrateur,id_type_personne)"
                                        + "VALUES (default, '" + ht["nom"] + "', '" + ht["prenom"] + "', '" + ht["email"] + "', '" + ht["login"] + "', '" + this.toMD5(ht["mdp"].ToString()) + "', true, 1);";

                                //on crée l'utilisateur 
                                sqlCommand = new MySqlCommand(req2, connexion);
                                reader = sqlCommand.ExecuteReader();
                                return true;
                            }
                            else
                            {
                                throw new Exception("La confirmation du mot de passe est incorrecte.");
                            }
                        }
                    }
                }
            }
            else // si c'est pour la création d'un compte employé (non admin)
            {
                if (ht["nom"].Equals("") || ht["prenom"].Equals("") || ht["email"].Equals(""))
                {
                    throw new Exception("Tous les champs doivent être remplis.");
                }
                else
                {
                    //verification que le mail n'existe pas déjà dans la base :
                    String req = "SELECT * FROM PERSONNE WHERE mail_personne='" + ht["email"] + "';";

                    int i = 0;

                    MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                    IDataReader reader = sqlCommand.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        i++;
                    }
                    reader.Close();

                    if (i==1)
                    {
                        throw new Exception("Cette adresse mail a déjà été utilisée.");
                    }
                    else
                    {
                        String req1 = "INSERT INTO PERSONNE(id_personne,nom_personne,prenom_personne,mail_personne,login_personne,mdp_personne,administrateur,id_type_personne)"+
                            "VALUES (default, '" + ht["nom"] + "', '" + ht["prenom"] + "', '" + ht["email"] + "', 'vide', 'vide', false, 1);";
                        
                        sqlCommand = new MySqlCommand(req1, connexion);
                        reader = sqlCommand.ExecuteReader();
                        return true;
                    }
                }
            }
        }

        /// <summary>
        /// Fonction qui effectue un changement de mot de passe d'un utilisateur dans la base de données
        /// </summary>
        /// <param name="p">personne qui souhaite changer son mot de passe (ou personne le mot de passe de laquelle on souhaite changer)</param>
        /// <param name="mdp">mot de passe actuel de la personne (non crypté)</param>
        /// <param name="nvoMdp">nouveau mot de passe de la personne (non crypté)</param>
        /// <param name="nvoMdpConfirm">la confirmation du nouveau mot de passe (non crypté)</param>
        /// <returns><c>true</c> si la création a réussi et crée une exception si la création a échoué</returns>
        public Boolean changerMdp(Personne p, String mdp, String nvoMdp, String nvoMdpConfirm)
        {
            //on verifie que tous les champs sont remplis
            if (mdp.Equals("") || nvoMdp.Equals("") || nvoMdpConfirm.Equals(""))
            {
                throw new Exception("Tous les champs doivent être remplis.");
            }
            else
            {
                //on vérifie que le mot de passe actuel est correctement saisi :
                if (p.getMdpPersonne().Equals(toMD5(mdp)))
                {
                    //on verifie que la confirmation du nouveau mot de passe a été correctement saisie : 
                    if (nvoMdp.Equals(nvoMdpConfirm))
                    {
                        p.setMdpPersonne(toMD5(mdp));

                        //on effectue la requete de modification
                        String req = "UPDATE PERSONNE SET mdp_personne='"+toMD5(nvoMdp)+"' WHERE id_personne="+p.getIdPersonne();

                        MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                        IDataReader reader = sqlCommand.ExecuteReader();
                        return true;
                    }
                    else
                    {
                        throw new Exception("La confirmation du nouveau mot de passe est incorrecte.");
                    }
                }
                else
                {
                    throw new Exception("Le mot de passe actuel est incorrecte");
                }
            }
        }

        /// <summary>
        /// Fonction qui permet d'ajouter un prêt de matériel dans la base de données 
        /// </summary>
        /// <param name="ht">tableau associatif qui contient toutes les donnée pour l'ajout : 
        /// <code>
        /// ht["date"]; ht["garantie"]; ht["id_pers"]; ht["marque"]; ht["type"];
        /// </code>
        /// </param>
        /// <returns>identifiant du matériel qui vient d'être ajouté dans la base de données, ou un exception si l'ajout a échoué</returns>
        public int ajouterMateriel(Hashtable ht)
        {
            if (!ht["garantie"].Equals(""))
            {
                //RECHERCHE DE L'IDENTIFIANT DE LA MARQUE DU MATERIEL
                int i = 0;
                MySqlCommand sqlCommandMarque = new MySqlCommand("SELECT id_marque FROM MARQUE WHERE nom_marque LIKE '" + ht["marque"] + "' LIMIT 0,1;", connexion);
                IDataReader readerMarque = sqlCommandMarque.ExecuteReader();
                while (readerMarque.Read())
                {
                    ht.Add("id_marque", readerMarque[0].ToString());
                    i++;
                }
                readerMarque.Close();

                //RECHERCHE DE L'IDENTIFIANT DU TYPE DU MATERIEL
                int j = 0;
                MySqlCommand sqlCommandType = new MySqlCommand("SELECT id_type_materiel FROM TYPE_MATERIEL WHERE type_materiel LIKE '" + ht["type"] + "' LIMIT 0,1;", connexion);
                IDataReader readerType = sqlCommandType.ExecuteReader();
                while (readerType.Read())
                {
                    ht.Add("id_type", readerType[0].ToString());
                    j++;
                }
                readerType.Close();

                String reqInsertMat = "INSERT INTO MATERIEL VALUES (default, '" + ht["date"] + "', '" + ht["garantie"] + "', '" + ht["id_pers"] + "', '" + ht["id_marque"] + "', '" + ht["id_type"] + "'); SELECT LAST_INSERT_ID();";
                MySqlCommand sqlCommand = new MySqlCommand(reqInsertMat, connexion);
                int lid = (int)Convert.ToInt32(sqlCommand.ExecuteScalar()); //on execute la requête tout en récupèrant l'identifiant qui vient de lui être attribué

                return lid;
            }
            else
            {
                throw new Exception("Veuillez compléter tous les champs.");
            }
        }

        /// <summary>
        /// Fonction qui permet d'ajouter une licence de durée
        /// </summary>
        /// <param name="ht">tableau associatif qui contient toutes les donnée pour l'ajout : 
        /// <code>
        /// ht["nom"]; ht["date"]; ht["duree"]; ht["id_pers"]; ht["numMatAssoc"]
        /// </code>
        /// </param>
        /// <returns>identifiant de la licence de durée qui vient d'être ajouté dans la base de données, ou un exception si l'ajout a échoué</returns>
        public int ajouterLicDuree(Hashtable ht)
        {
            //Si tous les champs obligatoirs sont remplis : 
            if (!ht["nom"].Equals("") && !ht["date"].Equals("") && !ht["duree"].Equals("") && !ht["id_pers"].Equals(""))
            {
                String req;
                //si la licence n'est associée à aucun matériel : 
                if (ht["numMatAssoc"].Equals(""))
                {
                    req = "INSERT INTO LICENCE_DUREE(id_licence_duree, nom_version, debut_licence, duree_licence, id_personne) VALUES (default, '" + ht["nom"] + "', '" + ht["date"] + "', '" + ht["duree"] + "', '" + ht["id_pers"] + "'); SELECT LAST_INSERT_ID();";
                }
                //si la licence est associée à un matériel : 
                else
                {
                    req = "INSERT INTO LICENCE_DUREE(id_licence_duree, nom_version, debut_licence, duree_licence, id_personne, id_materiel) VALUES (default, '" + ht["nom"] + "', '" + ht["date"] + "', '" + ht["duree"] + "', '" + ht["id_pers"] + "', '" + ht["numMatAssoc"] + "'); SELECT LAST_INSERT_ID();";
                }
                MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                int lid = (int)Convert.ToInt32(sqlCommand.ExecuteScalar()); //on execute la requête tout en récupèrant l'identifiant qui vient de lui être attribué

                return lid;
            }
            else
            {
                throw new Exception("Veuillez compléter tous les champs obligatoirs.");
            }
        }

        /// <summary>
        /// Fonction qui permet d'ajouter une licence de version
        /// </summary>
        /// <param name="ht">tableau associatif qui contient toutes les donnée pour l'ajout : 
        /// <code>
        /// ht["nom"]; ht["id_pers"]; ht["numMatAssoc"]
        /// </code>
        /// </param>
        /// <returns>identifiant de la licence de version qui vient d'être ajoutée dans la base de données, ou un exception si l'ajout a échoué</returns>
        public int ajouterLicVersion(Hashtable ht)
        {
            //Si tous les champs obligatoirs sont remplis : 
            if (!ht["nom"].Equals(""))
            {
                String req;
                //si la licence est associée à aucun matériel : 
                if (ht["NumMatAssoc"].Equals(""))
                {
                    req = "INSERT INTO LICENCE_VERSION(id_licence_version, nom_version, id_personne) VALUES (default, '" + ht["nom"] + "', '" + ht["id_pers"] + "'); SELECT LAST_INSERT_ID();";
                }
                //si la licence est associée à un matériel
                else
                {
                    req = "INSERT INTO LICENCE_VERSION(id_licence_version, nom_version, id_personne, id_materiel) VALUES (default, '" + ht["nom"] + "', '" + ht["id_pers"] + "', '" + ht["NumMatAssoc"] + "'); SELECT LAST_INSERT_ID();";
                }
                MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                int lid = (int)Convert.ToInt32(sqlCommand.ExecuteScalar()); //on execute la requête tout en récupèrant l'identifiant qui vient de lui être attribué

                return lid;
            }
            else
            {
                throw new Exception("Veuillez compléter tous les champs obligatoirs.");
            }
        }

        /// <summary>
        /// Fonction qui permet de supprimer un matériel dans la base de données
        /// </summary>
        /// <param name="id">identifiant du matériel à supprimer </param>
        public void suppMateriel(int id)
        {
            try
            {
                String req = "DELETE FROM MATERIEL WHERE id_materiel=" + id;

                MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                IDataReader reader = sqlCommand.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur dans la requête, le matériel n'a pas été supprimé : " + ex.Message);
            }
        }

        /// <summary>
        /// Fonction qui permet de supprimet une licence de durée dans la base de données
        /// </summary>
        /// <param name="id">identifiant de la licence de durée</param>
        public void suppLicDuree(int id)
        {
            try
            {
                String req = "DELETE FROM LICENCE_DUREE WHERE id_licence_duree=" + id;

                MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                IDataReader reader = sqlCommand.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur dans la requête, la licence de durée n'a pas été supprimée : " +  ex.Message);
            }
        }

        /// <summary>
        /// Fonction qui permet de supprimet une licence de version dans la base de données
        /// </summary>
        /// <param name="id">identifiant de la licence de version</param>
        public void suppLicVersion(int id)
        {
            try
            {
                String req = "DELETE FROM LICENCE_VERSION WHERE id_licence_version=" + id;

                MySqlCommand sqlCommand = new MySqlCommand(req, connexion);
                IDataReader reader = sqlCommand.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur dans la requête, la licence de version n'a pas été supprimé : " + ex.Message);
            }
        }

        /// <summary>
        /// Fonction qui permet de crypter une chaine de caractères avec MD5
        /// </summary>
        /// <param name="strText">chaine de caractères à crypter</param>
        /// <returns>chaine cryptée de 32 caractères</returns>
        public string toMD5(string strText)
        {
            //le code qui suit a pris d'un forum : http://www.developpez.net/forums/d104312/dotnet/developpement-web-net/asp-net/csharp-cryptage-md5/
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace GestionArrivee
{
    class DbInscriptions
    {
        MySqlDataReader reader;
        Dbconnect Connex;

        public DbInscriptions()
        {
        }

        public bool AjouterInscription(Inscriptions UnInscription)
        {
            bool opeOK = false;
            try
            {
                string bddServeur = ConfigurationManager.AppSettings["serveur"];
                string sBddPort = ConfigurationManager.AppSettings["port"];
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = ConfigurationManager.AppSettings["base"];
                string bddIdent = ConfigurationManager.AppSettings["identificateur"];
                string bddMdp = ConfigurationManager.AppSettings["mdp"];

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);

                if (Connex.OuvrirConnexion())
            {
                string requete = "INSERT INTO `Inscription` (`NumDossard`, `coureur_IdCoureur`, `transpondeur_IdTranspondeur`, `course_IdCourse`) " +
                    "VALUES ('"+ UnInscription.NumDossard + "', '"+ UnInscription.IdCoureur + "', '"+ UnInscription.IdTranspondeur + "', '"+ UnInscription.IdCourse + "')";
                Connex.RequeteNoData(requete);
                opeOK = true;
            }
            }
            catch
            {
                opeOK = false;
            }
            Connex.FermerConnexion();
            return opeOK;
        }

        public (bool, string) ModifierInscription(Inscriptions UnInscription, int IdInscription)
        {
            bool opeOK = false;
            int ligneMod = 0;
            string messErreur ="";
            try
            {
                string bddServeur = ConfigurationManager.AppSettings["serveur"];
                string sBddPort = ConfigurationManager.AppSettings["port"];
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = ConfigurationManager.AppSettings["base"];
                string bddIdent = ConfigurationManager.AppSettings["identificateur"];
                string bddMdp = ConfigurationManager.AppSettings["mdp"];

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);

                if (Connex.OuvrirConnexion())
                {
                    string requete = "UPDATE inscription SET `NumDossard`= '" + UnInscription.NumDossard + "', `coureur_IdCoureur`= '" + UnInscription.IdCoureur + "', `transpondeur_IdTranspondeur`= '" + UnInscription.IdTranspondeur + "', `course_IdCourse`= '" + UnInscription.IdCourse + "' WHERE IdInscription = " + IdInscription + "";
                    ligneMod = Connex.RequeteNoData(requete);
                    if (ligneMod == 0)
                    {
                        messErreur = Connex.Erreur;
                        opeOK = false;
                    }
                    else
                    {
                        opeOK = true;
                    }
                }
            }
            catch
            {
                opeOK = false;
                messErreur = "Erreur de connexion !";
            }
            Connex.FermerConnexion();
            return (opeOK, messErreur);
        }

        public (bool, string) SupprimerInscription(Inscriptions UnInscription, int IdInscription)
        {
            bool opeOK = false;
            int ligneMod = 0;
            string messErreur="";

            try
            {
                string bddServeur = ConfigurationManager.AppSettings["serveur"];
                string sBddPort = ConfigurationManager.AppSettings["port"];
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = ConfigurationManager.AppSettings["base"];
                string bddIdent = ConfigurationManager.AppSettings["identificateur"];
                string bddMdp = ConfigurationManager.AppSettings["mdp"];

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);

                if (Connex.OuvrirConnexion())
                {
                    string requete = "DELETE FROM inscription WHERE IdInscription = " + IdInscription;
                    ligneMod = Connex.RequeteNoData(requete);
                    if (ligneMod == 0)
                    {
                        messErreur = Connex.Erreur;
                        opeOK = false;
                    }else
                    {
                        opeOK = true;
                    }
                }
            }
            catch
            {
                opeOK = false;
                messErreur = "Erreur de connexion !";
            }
            Connex.FermerConnexion();
            return (opeOK, messErreur);
        }


        public MySqlDataReader LecturetoutInscription()
        {
            try
            {
                string bddServeur = ConfigurationManager.AppSettings["serveur"];
                string sBddPort = ConfigurationManager.AppSettings["port"];
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = ConfigurationManager.AppSettings["base"];
                string bddIdent = ConfigurationManager.AppSettings["identificateur"];
                string bddMdp = ConfigurationManager.AppSettings["mdp"];

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);

                if (Connex.OuvrirConnexion())
                {
                    string requete = "SELECT * FROM inscription";
                    reader = Connex.RequeteSql(requete);
                    return reader;
                }
            }
            catch
            {
                return reader;
            }
            Connex.FermerConnexion();
            return reader;
            
        }

        public MySqlDataReader LectureDernierInscription()
        {
            try
            {
                string bddServeur = ConfigurationManager.AppSettings["serveur"];
                string sBddPort = ConfigurationManager.AppSettings["port"];
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = ConfigurationManager.AppSettings["base"];
                string bddIdent = ConfigurationManager.AppSettings["identificateur"];
                string bddMdp = ConfigurationManager.AppSettings["mdp"];

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);

                if (Connex.OuvrirConnexion())
                {
                    string requete = "SELECT MAX(NumDossard) FROM inscription";
                    reader = Connex.RequeteSql(requete);
                    return reader;
                }
            }
            catch
            {
                return reader;
            }
            Connex.FermerConnexion();
            return reader;
        }

        public MySqlDataReader LectureunInscrit(Int32 NumTranspondeur)
        {
            try
            {
                string bddServeur = ConfigurationManager.AppSettings["serveur"];
                string sBddPort = ConfigurationManager.AppSettings["port"];
                int bddPort = Convert.ToInt16(sBddPort);
                string bddBase = ConfigurationManager.AppSettings["base"];
                string bddIdent = ConfigurationManager.AppSettings["identificateur"];
                string bddMdp = ConfigurationManager.AppSettings["mdp"];

                Connex = new Dbconnect(bddServeur, bddPort, bddBase, bddIdent, bddMdp);

                if (Connex.OuvrirConnexion())
                {
                    string requete = "SELECT * FROM inscription WHERE transpondeur_IdTranspondeur = " + NumTranspondeur;

                    reader = Connex.RequeteSql(requete);
                    return reader;
                }
                else
                {
                    return reader;
                }

            }
            catch
            {
                Connex.FermerConnexion();
                return reader;
            }
        }
    }
}

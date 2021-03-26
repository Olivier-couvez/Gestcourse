using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace GestionCourses
{
    class DbCategories
    {
        MySqlDataReader reader;
        Dbconnect Connex;

        public DbCategories()
        {
        }

        public bool AjouterCategories(Categories UneCategories)
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
                string requete = "INSERT INTO `categorie` (`Nom`, `AgeMini`, `AgeMaxi`, `DistanceMax`) " +
                    "VALUES ('"+ UneCategories.Nom + "', '"+ UneCategories.ageMini + "', '"+ UneCategories.ageMaxi + "', '"+ UneCategories.dista + "')";
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

        public (bool, string) ModifierCategories(Categories UneCategories, int IdCategories)
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
                    string requete = "UPDATE categorie SET `Nom`= '" + UneCategories.Nom + "', `AgeMini`= '" + UneCategories.ageMini + "', `AgeMaxi`= '" + UneCategories.ageMaxi + "', `DistanceMax`= '" + UneCategories.dista + "' WHERE IdCategorie = " + IdCategories + "";
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

        public (bool, string) SupprimerCategories(Categories UneCategories, int IdCategories)
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
                    string requete = "DELETE FROM categorie WHERE IdCategorie = " + IdCategories ;
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


        public MySqlDataReader LecturetoutCategories()
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
                    string requete = "SELECT * FROM categorie";
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
    }
}

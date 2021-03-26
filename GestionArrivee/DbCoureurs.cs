using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace GestionArrivee
{
    class DbCoureurs
    {
        MySqlDataReader reader;
        Dbconnect Connex;

        public DbCoureurs()
        {
        }

        public bool AjouterCoureur(Coureurs UnCoureurs)
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
                    // mettre la date dansq le format Mysql 

                    string datnais = Convert.ToDateTime(UnCoureurs.Date).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datnais = datnais.Replace("T", " ");


                    string requete = "INSERT INTO `coureur` (`Club_IdClub`, `Nom`, `Prenom`, `Adresse`, `CodePostal`, `Ville`, `DateNaissance`, `Sexe`, `Categorie_IdCategorie`) " +
                        "VALUES ('" + UnCoureurs.IdClub + "', '" + UnCoureurs.Nom + "', '" + UnCoureurs.Prenom + "', '" + UnCoureurs.Adresse +
                        "', '" + UnCoureurs.Cp + "', '" + UnCoureurs.Ville + "', '" + datnais + "', '" + UnCoureurs.Sexe + "', '" + UnCoureurs.IdCat +"')";
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

        public (bool, string) ModifierCoureurs(Coureurs UnCoureurs, int IdCoureurs)
        {
            bool opeOK = false;
            int ligneMod = 0;
            string messErreur = "";
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
                    // mettre la date dans le format Mysql 

                    string datnais = Convert.ToDateTime(UnCoureurs.Date).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datnais = datnais.Replace("T", " ");

                    string requete = "UPDATE Coureur SET `Club_IdClub`= '"+ UnCoureurs.IdClub +"', `Nom`= '" + UnCoureurs.Nom + "', `Prenom`= '" + UnCoureurs.Prenom
                        + "', `Adresse`= '" + UnCoureurs.Adresse + "', `CodePostal`= '" + UnCoureurs.Cp + "', `Ville`= '" + UnCoureurs.Ville + 
                        "', `DateNaissance`= '" + datnais + "', `Sexe`= '" + UnCoureurs.Sexe + "', `Categorie_IdCategorie`= '" + UnCoureurs.IdCat +
                        "' WHERE IdCoureur = " + IdCoureurs + "";

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

        public (bool, string) SupprimerCoureurs(Coureurs UnCoureurs, int IdCoureurs)
        {
            bool opeOK = false;
            int ligneMod = 0;
            string messErreur = "";

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
                    string requete = "DELETE FROM Coureur WHERE IdCoureur = " + IdCoureurs;
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


        public MySqlDataReader LecturetoutCoureurs()
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
                    string requete = "SELECT * FROM Coureur";
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

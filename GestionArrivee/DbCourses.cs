using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;

namespace GestionArrivee
{
    class DbCourses
    {
        MySqlDataReader reader;
        Dbconnect Connex;

        public DbCourses()
        {
        }

        public bool AjouterCourse(Courses UnCourse)
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
                    string datprevue = Convert.ToDateTime(UnCourse.DatePrevue).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datprevue = datprevue.Replace("T", " ");
                    string datheure = Convert.ToDateTime(UnCourse.HeureDepart).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datheure = datheure.Replace("T", " ");

                    string requete = "INSERT INTO `course` (`Nom`, `Date`, `Distance`, `HeureDepart`) " +
                        "VALUES ('" + UnCourse.Nom + "', '" + datprevue + "', '" + UnCourse.Distance + "', '" + datheure + "')";

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

        public (bool, string) ModifierCourse(Courses UnCourse, int IdCourse)
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
                    string datprevue = Convert.ToDateTime(UnCourse.DatePrevue).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datprevue = datprevue.Replace("T", " ");
                    string datheure = Convert.ToDateTime(UnCourse.HeureDepart).ToString("s", DateTimeFormatInfo.InvariantInfo);
                    datheure = datheure.Replace("T", " ");

                    string requete = "UPDATE course SET `Nom`= '" + UnCourse.Nom + "', `Date`= '" +
                        datprevue + "', `Distance`= '" + UnCourse.Distance + "', `HeureDepart`= '" +
                        datheure + "' WHERE IdCourse = " + IdCourse + "";
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

        public (bool, string) SupprimerCourse(Courses UnCourse, int IdCourse)
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
                    string requete = "DELETE FROM course WHERE IdCourse = " + IdCourse;
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


        public MySqlDataReader LecturetoutCourse()
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
                    string requete = "SELECT * FROM course";
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

        public MySqlDataReader LectureUneCourse(int idxCourse)
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
                    string requete = "SELECT * FROM course where IdCourse = " + idxCourse;
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



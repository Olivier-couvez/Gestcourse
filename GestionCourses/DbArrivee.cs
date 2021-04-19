using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;

namespace GestionCourses
{
    class DbArrivee
    {
        MySqlDataReader reader;
        Dbconnect Connex;

        public DbArrivee()
        {
        }
        public MySqlDataReader LectureArrivee(int id)
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
                    string requete = "select inscription.NumDossard, coureur.Nom, coureur.Prenom, categorie.Nom, club.Nom, arrivee.Temps " +
                        "from inscription, course, coureur, categorie, club, arrivee where course.IdCourse ="+ id +
                        " AND inscription.course_IdCourse = course.IdCourse AND coureur.IdCoureur = inscription.coureur_IdCoureur AND" +
                        " arrivee.Inscription_IdInscription = inscription.IdInscription AND categorie.IdCategorie = coureur.Categorie_IdCategorie AND" +
                        " club.IdClub = coureur.Club_IdClub ORDER BY arrivee.Temps";
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



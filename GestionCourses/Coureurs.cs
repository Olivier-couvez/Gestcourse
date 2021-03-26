using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourses
{
    class Coureurs
    {
        private int id;
        private int idClub;
        private string nom;
        private string prenom;
        private string adresse;
        private Int32 cp;
        private string ville;
        private DateTime date;
        private char sexe;
        private int idCat;

        public Coureurs(int _id, int _idClub, string _nom, string _prenom, string _adresse, Int32 _cp, string _ville, DateTime _date, char _sexe, int _idCat)
        {
            id = _id;
            idClub = _idClub;
            nom = _nom;
            prenom = _prenom;
            adresse = _adresse;
            cp = _cp;
            ville = _ville;
            date = _date;
            sexe = _sexe;
            idCat = _idCat;
        }

        public Coureurs(int _idClub, string _nom, string _prenom, string _adresse, Int32 _cp, string _ville, DateTime _date, char _sexe, int _idCat)
        {
            idClub = _idClub;
            nom = _nom;
            prenom = _prenom;
            adresse = _adresse;
            cp = _cp;
            ville = _ville;
            date = _date;
            sexe = _sexe;
            idCat = _idCat;
        }

        public int Id { get => Id; set => Id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public Int32 Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime Date { get => date; set => date = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public int IdClub { get => idClub; set => idClub = value; }
        public int IdCat { get => idCat; set => idCat = value; }
    }

}

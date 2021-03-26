using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArrivee
{
    class Clubs
    {
        private int id;
        private string nom;
        private string adresse;
        private string cp;
        private string ville;
        
        public Clubs(int _id, string _nom, string _adresse, string _cp, string _ville)
        {
            Id = _id;
            Nom = _nom;
            adresse = _adresse;
            Cp = _cp;
            ville = _ville;
        }

        public Clubs(string _nom, string _adresse, string _cp, string _ville)
        {
            Nom = _nom;
            adresse = _adresse;
            Cp = _cp;
            ville = _ville;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
    }
}

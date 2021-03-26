using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourses
{
    class Categories
    {
        private int id;
        private string nom;
        private int ageMin;
        private int ageMax;
        private int dist;
        
        public Categories(int _id, string _nom, int _ageMin, int _ageMax, int _dist)
        {
            Id = _id;
            Nom = _nom;
            ageMin = _ageMin;
            ageMax = _ageMax;
            dist = _dist;
        }

        public Categories(string _nom, int _ageMin, int _ageMax, int _dist)
        {
            Nom = _nom;
            ageMin = _ageMin;
            ageMax = _ageMax;
            dist = _dist;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int ageMini { get => ageMin; set => ageMin = value; }
        public int ageMaxi { get => ageMax; set => ageMax = value; }
        public int dista { get => dist; set => dist = value; }
    }
}

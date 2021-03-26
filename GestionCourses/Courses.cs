using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCourses
{
    class Courses
    {
        private int id;
        private string nom;
        private DateTime datePrevue;
        private string distance;
        private DateTime heureDepart;
        private int enCours;

        public Courses(int _id, string _nom, DateTime _datePrevue, string _distance, DateTime _heureDepart, int _enCours)
        {
            id = _id;
            nom = _nom;
            datePrevue = _datePrevue;
            distance = _distance;
            heureDepart = _heureDepart;
            enCours = _enCours;
        }

        public Courses(string _nom, DateTime _datePrevue, string _distance, DateTime _heureDepart, int _enCours)
        {
            nom = _nom;
            datePrevue = _datePrevue;
            distance = _distance;
            heureDepart = _heureDepart;
            enCours = _enCours;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DatePrevue { get => datePrevue; set => datePrevue = value; }
        public string Distance { get => distance; set => distance = value; }
        public DateTime HeureDepart { get => heureDepart; set => heureDepart = value; }
        public int EnCours { get => enCours; set => enCours = value; }
    }
}

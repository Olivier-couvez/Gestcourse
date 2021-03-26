using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArrivee
{
    class Courses
    {
        private int id;
        private string nom;
        private DateTime datePrevue;
        private string distance;
        private DateTime heureDepart;
        
        public Courses(int _id, string _nom, DateTime _datePrevue, string _distance, DateTime _heureDepart)
        {
            id = _id;
            nom = _nom;
            datePrevue = _datePrevue;
            distance = _distance;
            heureDepart = _heureDepart;
        }

        public Courses(string _nom, DateTime _datePrevue, string _distance, DateTime _heureDepart)
        {
            nom = _nom;
            datePrevue = _datePrevue;
            distance = _distance;
            heureDepart = _heureDepart;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DatePrevue { get => datePrevue; set => datePrevue = value; }
        public string Distance { get => distance; set => distance = value; }
        public DateTime HeureDepart { get => heureDepart; set => heureDepart = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArrivee
{
    class Inscriptions
    {
        private int id;
        private Int32 numDossard;
        private Int32 idCoureur;
        private Int32 idTranspondeur;
        private Int32 idCourse;
        
        public Inscriptions(int _id, Int32 _numDossard, Int32 _idCoureur, Int32 _idTranspondeur, Int32 _idCourse)
        {
            Id = _id;
            numDossard = _numDossard;
            idCoureur = _idCoureur;
            idTranspondeur = _idTranspondeur;
            idCourse = _idCourse;
        }

        public Inscriptions(Int32 _numDossard, Int32 _idCoureur, Int32 _idTranspondeur, Int32 _idCourse)
        {
            numDossard = _numDossard;
            idCoureur = _idCoureur;
            idTranspondeur = _idTranspondeur;
            idCourse = _idCourse;
        }

        public int Id { get => id; set => id = value; }
        public Int32 NumDossard { get => numDossard; set => numDossard = value; }
        public Int32 IdCoureur { get => idCoureur; set => idCoureur = value; }
        public Int32 IdTranspondeur { get => idTranspondeur; set => idTranspondeur = value; }
        public Int32 IdCourse { get => idCourse; set => idCourse = value; }
    }
}

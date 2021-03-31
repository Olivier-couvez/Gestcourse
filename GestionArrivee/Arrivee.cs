using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArrivee
{
    class Arrivee
    {
        private int id;
        private DateTime temps;
        private int idArrivee;

        public Arrivee()
        {

        }
        
        public Arrivee(int _id, DateTime _temps, int _idArrivee)
        {
            Id = _id;
            temps = _temps;
            idArrivee = _idArrivee;
        }

        public Arrivee(DateTime _temps , int _idArrivee)
        {
            temps = _temps;
            idArrivee = _idArrivee;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Temps { get => temps; set => temps = value; }
        public int IdInscription { get => idArrivee; set => idArrivee = value; }
    }
}

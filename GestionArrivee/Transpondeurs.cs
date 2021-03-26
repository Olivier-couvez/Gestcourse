using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArrivee
{
    class Transpondeurs
    {
        private Int32 id;
        private int perdu;

        
        public Transpondeurs(Int32 _id, int _perdu)
        {
            Id = _id;
            Perdu = _perdu;
            
        }
        public Transpondeurs(int _perdu)
        {
            Perdu = _perdu;

        }


        public Int32 Id { get => id; set => id = value; }
        public int Perdu { get => perdu; set => perdu = value; }

    }
}

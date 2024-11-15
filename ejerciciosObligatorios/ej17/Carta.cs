using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    internal class Carta
    {
        int num;
        string palo;
        enum PalosBarEspañola
        {
            OROS,
            COPAS,
            ESPADAS,
            BASTOS
        }
        enum PalosBarFrancesa
        {
            DIAMANTES,
            PICAS,
            CORAZONES,
            TREBOLES
        }
        public int Num { get { return num; } set { num = value; } }
        public string Palo { get { return palo; } set { palo = value; } }

        public Carta(int N, string P)
        {
            num = N;
            palo = P;
        }
    }
}

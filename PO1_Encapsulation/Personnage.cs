using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    internal class Personnage
    {
        int pointsDeVie;
        int puissanceAttaque;

        public int PointsDeVie { get => pointsDeVie; set => pointsDeVie = value; }
        public int PuissanceAttaque { get => puissanceAttaque; set => puissanceAttaque = value; }
    }
}

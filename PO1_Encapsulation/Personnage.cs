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
        int pointsDeVieMaximal;

        public int PointsDeVie
        {
            get => pointsDeVie;
            set
            {
                if (value < 0)
                {
                    pointsDeVie = 0;
                }
                else pointsDeVie = value;
            }
        }
        public int PuissanceAttaque { get => puissanceAttaque; set => puissanceAttaque = value; }
    }
    
    }

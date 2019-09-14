using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Compositions.Minifigures.Pieces
{
    class PirateLegs : Legs
    {
        public PirateLegs()
        {
            NumberOfLegs = 1;
            PantLength = PantLength.Capris;
            Vertical = 2;
        }
    }

    class ZombieLegs : Legs
    {
        public ZombieLegs()
        {
            NumberOfLegs = 0;
            PantLength = PantLength.None;
            Vertical = 0;
            BareFoot = true;
        }
    }

    class CentaurLegs : Legs
    {
        public CentaurLegs()
        {
            NumberOfLegs = 4;
            PantLength = PantLength.None;
            Vertical = 100;

        }
    }
}

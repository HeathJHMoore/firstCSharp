using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Compositions.Minifigures.Pieces
{
    enum PantLength
    {
        Shorts,
        Pants,
        Capris,
        None
    }
    class Legs
    {
        public PantLength PantLength { get; set; }
        public bool BareFoot { get; set; }
        public int Vertical { get; set; }
        public int NumberOfLegs { get; set; }

        public virtual void Kick()
        {
            UseLegs("Kick");
        }

        public void Dance()
        {
            UseLegs("Dance");
        }

        public void Walk()
        {
            UseLegs("walk");
        }

        private void UseLegs(string activity)
        {
                if (NumberOfLegs <= 0)
                {
                    Console.WriteLine($"No legs, cant {activity}");
                    return;
                }
                Console.WriteLine($"The {NumberOfLegs} legs {activity} {(BareFoot ? "without shoes" : "with Shoes")} while wearing {PantLength}");
        }
    }
}

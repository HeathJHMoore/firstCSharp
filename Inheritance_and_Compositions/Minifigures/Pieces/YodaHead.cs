using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Compositions.Minifigures.Pieces
{
    class YodaHead : Head, ITalker
    {
        public bool HasEars { get; private set; }
        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }

        public void Battle()
        {
            HasEars = false;
            MouthIsOpen = true;
        }

        public override void Talk()
        {
            Console.WriteLine("Talking head I am.");
        }

    }
}

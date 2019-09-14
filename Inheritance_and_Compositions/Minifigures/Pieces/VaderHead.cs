using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Compositions.Minifigures.Pieces
{
    class VaderHead : Head
    {
        public void Think()
        {
            Console.WriteLine("Am I your father?");
        }

        public override void Talk()
        {
            Console.WriteLine("KHOOOH PUUUUUUHR");
            base.Talk();
        }
    }
}

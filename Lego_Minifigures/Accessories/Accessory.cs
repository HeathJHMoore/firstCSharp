using System;
using System.Collections.Generic;
using System.Text;

namespace Lego_Minifigures.Accessories
{
    class Accessory
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string SpecialEffectDescription { get; set; }

        public void SpecialEffect()
        {
            Console.WriteLine(SpecialEffectDescription);
        }

    }
}

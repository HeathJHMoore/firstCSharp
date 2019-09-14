using System;
using System.Collections.Generic;
using System.Text;
using Lego_Minifigures.Accessories;

namespace Lego_Minifigures
{
    class Character
    {
        public string Head { get; set; }

        public string HairHat { get; set; }

        public string Torso { get; set; }

        public string Legs { get; set; }

        public Accessory Accessory { get; set; }

        public Character(string head, string hairHat, string torso, string legs, Accessory accessoryItem)
        {
            Head = head;
            HairHat = hairHat;
            Torso = torso;
            Legs = legs;
            Accessory = accessoryItem;
        }


    }
}

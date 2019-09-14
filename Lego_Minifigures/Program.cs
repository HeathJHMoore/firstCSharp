using System;
using Lego_Minifigures.Accessories;
namespace Lego_Minifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var Firefighter = new Character(
                "Firefighter Helmet",
                "Black Hair",
                "Firefighter Coat",
                "Fireproof Pants",
                new Accessory { Name = "Firehose", Color = "Red", SpecialEffectDescription = "Sprays Water" }
            );

            Console.WriteLine(Firefighter.Head);
            Console.WriteLine(Firefighter.Legs);
            Console.WriteLine(Firefighter.Accessory.SpecialEffectDescription);
        }
    }
}

using Inheritance_and_Compositions.Minifigures;
using Inheritance_and_Compositions.Minifigures.Pieces;
using System;

namespace Inheritance_and_Compositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var newHead = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = true,
                MouthIsOpen = true,
                NumberOfEyes = 2
            };

            var newLegs = new CentaurLegs() { }


            var minifigure = new Minifigure(newHead);
            minifigure.Battle();
        
            var fatHead = new FatHead();
            fatHead.Talk();
            minifigure.Head.Talk();
            Console.WriteLine(fatHead.EyeColor, "this is eye color");


            var vaderHead = new VaderHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = true,
                MouthIsOpen = true,
                NumberOfEyes = 2
            };
            var newminifigure = new Minifigure(vaderHead);
          
            
        }
    }
}

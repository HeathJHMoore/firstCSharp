using System;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var Drake = new Rapper { Name = "Drake", BestLine = "I'm on a roll like cottonelle, i was made for all this shit" };

            var twoChainz = new Rapper { Name = "2 Chainz", BestLine = "Teach you how to make a million, call that a mill plan" };

            Drake.DissSomebody();

            Drake.SpitBars("These days, im letting God handle all things above me");

            Console.WriteLine(Drake.BestLine);
        }
    }
}

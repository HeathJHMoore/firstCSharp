using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Rapper
    {

        public string Name { get; set; }
        public string BestLine { get; set; }

        public void SpitBars(string barsToSpit)
        {
            Console.WriteLine(barsToSpit);
        }

        public void DissSomebody ()
        {
            Console.WriteLine("You lame bruh");
        }
    }
}

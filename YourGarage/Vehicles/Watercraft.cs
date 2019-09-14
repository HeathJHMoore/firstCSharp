using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles
{
    class Watercraft : Vehicle
    {
        public Watercraft(string color, int passengers)
        {
            FuelCapacity = 100;
            Color = color;
            Passengers = passengers;
        }

        public void driving()
        {
            FuelCapacity -= 2;
            Console.WriteLine("Yo I am riding in a boat");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles
{
    class Aircraft : Vehicle
    {

        public Aircraft(string color, int passengers)
        {
            FuelCapacity = 100;
            Color = color;
            Passengers = passengers;
        }

        public void Flying()
        {
            FuelCapacity -= 2;
            Console.WriteLine("Yo we are flying the aircraft");
        }

        public void Land()
        {
            Console.WriteLine("Yo we are landing the aircraft");
        }
    }
}

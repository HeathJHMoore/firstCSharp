using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles
{
    abstract class Vehicle
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int Passengers { get; set; }

        public void refueling(int gas)
        {
            FuelCapacity += gas;
            Console.WriteLine($"you just added {gas} fuel");
        }
    }
}

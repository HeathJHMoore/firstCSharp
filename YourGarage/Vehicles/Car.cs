using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles
{
    abstract class Car : Vehicle
    {

        public void driving()
        {
            base.FuelCapacity -= 2;
            Console.WriteLine("Yo I am driving a car");
        }

        public void braking()
        {
            Console.WriteLine("Yo we are braking in the car");
        }

    }
}

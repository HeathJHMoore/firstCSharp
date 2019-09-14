using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Car
    {
        public string Color { get; set; }
        public int TopSpeed { get; set; }
        public bool IsInsured { get; set; }

        decimal _gasLevel;

        bool _isRunning;
        Person _driver;
        int _currentSpeed;

        const decimal GasToStart = .5m;

        public Car(decimal gaslevel)
        {
            _gasLevel = gaslevel;
        }

        public void Start(Person driver)
        {
            if (_isRunning) return;

            if (_gasLevel > GasToStart)
            {
                _isRunning = true;
                _driver = driver;
                _gasLevel -= .5m;
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("You're out of gas");
            }
        }

        public void Accelerate(int howMuchFaster)
        {
            if (!_isRunning)
            {
                Console.WriteLine("You need to start the car first. Please call the Start() method on the Car class");
                return;
            }
            else
            {
                _currentSpeed += howMuchFaster;
                _gasLevel -= 1;
            }
            if (_gasLevel <= 0) _isRunning = false;
        }

        public decimal Refuel(decimal amountOfGas)
        {
            _gasLevel += amountOfGas;
            return _gasLevel;
        }

    }
}

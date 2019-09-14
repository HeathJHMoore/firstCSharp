using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        int _speed;

        int _caloricIntake = 0;

        const int MaxWalkingSpeed = 10;

        List<string> _foodInMyBelly = new List<string>();


        public Person(string name, int age, int speed)
        {
            Name = name;
            Age = age;
            _speed = speed;
        }

        public void Walk()
        {
            if (_speed < MaxWalkingSpeed)
            {
                Console.WriteLine($"{Name} is walking at {_speed} feet per second");
            }
            else
            {
                Console.WriteLine($"Bro why you runnin?");
            }
        }

        public void Eat(string foodType, int calories)
        {
            if (_caloricIntake > 2500)
            {
                Console.WriteLine("you cant eat");
                return;
            }

            _foodInMyBelly.Add(foodType);
            _caloricIntake += calories;
        }

    }
}

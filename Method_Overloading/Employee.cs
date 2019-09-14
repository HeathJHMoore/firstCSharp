using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overloading
{
    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Employee> _myFriends = new List<Employee>();

        List<string> _restaurants = new List<string>()
        {
            "Newks",
            "Chipotle",
            "Pizza Hut"
        };

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            Random randomNumber = new Random();
            decimal realRandom = Convert.ToDecimal(randomNumber.NextDouble());
            decimal topIndex = _restaurants.Count;
            decimal index = Math.Floor(realRandom * topIndex);
            string randomRestaurant = _restaurants[Convert.ToInt32(index)];
            Console.WriteLine($"I, {FirstName} {LastName}, am eating at {randomRestaurant}");
        }

        public void eat(string food)
        {
            Console.WriteLine($"I {FirstName} {LastName} am eating {food} at the office");
        }


        public void eat(List<Employee> companions)
        {
            eat();
            foreach (Employee companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }
        }

        public void eat(string food, List<Employee> companions)
        {
            eat();
            Console.WriteLine($"At this restaurant, I am eating {food}");
            foreach (Employee companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
        }

        public void addFriend(Employee newFriend)
        {
            _myFriends.Add(newFriend);
        }

    }
}

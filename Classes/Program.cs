using System;

namespace Classes
{
    class Program
    {
        string FullName { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var name = new Name {FullName = "string", FirstName = "pal"};

            var steve = new Person("steve", 23, 100);


            steve.Walk();

            steve.Eat("pizza", 800);

            var newCar = new Car(5);

            newCar.Start(steve);

            newCar.Accelerate(10);

        }
    }
}

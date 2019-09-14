using System;
using System.Collections.Generic;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bob = new Employee("Bob", "Jones");

            var Alli = new Employee("Alli", "Barker");

            var John = new Employee("John", "Smith");

            var Catherine = new Employee("Catherine", "Bogel");

            Bob.addFriend(Alli);
            Bob.addFriend(John);
            Bob.addFriend(Catherine);
            


            Bob.eat();
            Bob.eat("pizza");
            Bob.eat(Bob._myFriends);
            Bob.eat("pizza", Bob._myFriends);
        }
    }
}

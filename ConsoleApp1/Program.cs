using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool myBool = false;

            if (myBool)
            {
                Console.WriteLine("we wont hit this code");
            }

            switch (myBool)
            {
                case true:
                    Console.WriteLine("hey");
                    break;
            }

            for (var i=0; i < 5; i++)
            {
                Console.WriteLine($"we on iteration {i}");
            }

            List<string> myStrings = new List<string>();

            foreach(var myString in myStrings)
            {
                Console.WriteLine(myString);
            }
        }
    }
}

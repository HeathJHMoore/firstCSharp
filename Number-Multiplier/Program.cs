using System;

namespace Number_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string userOption = "";
            do
            {
                Console.WriteLine("Enter a list of integers like the following format: 1,4,6,8. Type exit to quit");
                userInput = Console.ReadLine();
                Console.WriteLine("Would you like to square or multiply this series?");
                userOption = Console.ReadLine();
                userOption = userOption.ToLower();
                string[] userNumbers = userInput.Split(",");
                int multiplytotal = 0;
                string squaredList = "";
                foreach (string item in userNumbers)
                {
                    if (userOption == "multiply")
                    {
                        multiplytotal += int.Parse(item);
                    }
                    else
                    {
                        squaredList += $"{int.Parse(item) * int.Parse(item)},";
                    } 
                }
                if (userOption == "multiply")
                {
                    Console.WriteLine(multiplytotal);
                }
                else if (userOption == "square")
                {
                    Console.WriteLine(squaredList);
                }
                else
                {
                    Console.WriteLine("you didnt enter a valid answer");
                }

            }
            while (userInput != "exit");
        }
    }
}

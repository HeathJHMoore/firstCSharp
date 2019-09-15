using System;

namespace RomanNumeralConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var RomanNumeralConverter = new RomanNumeralConverter();
            var userInput = "";
            do
            {
                Console.WriteLine("Please Enter a Number between 1 and 3999 to convert to Roman Numeral");
                Console.WriteLine("Or type exit to leave this program");
                userInput = Console.ReadLine();
                var userInputToInteger = int.Parse(userInput);
                var output = RomanNumeralConverter.Convert(userInputToInteger);
                Console.WriteLine($"{userInput} converts to {output}");
            } while (userInput != "exit");
        }
    }
}

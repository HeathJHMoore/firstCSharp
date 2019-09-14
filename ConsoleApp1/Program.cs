using System;
using System.Collections.Generic;

namespace LetterLooper
{
    class Program
    { 
        static void Main(string[] args)
        {
            string phrase;
            do
            {
                Console.WriteLine("Please enter a string of letters");
                phrase = Console.ReadLine();
                int phraseLength = phrase.Length;
                int count = 1;
                string newPhrase = "";
                foreach (char letter in phrase)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (i == 0)
                        {
                            newPhrase += Char.ToUpper(letter);
                        }
                        else
                        {
                            newPhrase += letter;
                        }
                    }
                    if (count != phraseLength)
                    {
                        newPhrase += "-";
                    }
                    count += 1;
                }
                Console.WriteLine($"{newPhrase}");
            }
            while (phrase != "exit");
        }
    }
}

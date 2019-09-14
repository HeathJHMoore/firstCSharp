using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>();
            strings.Add("hey");
            strings.Add("blarg");
            List<string> howdy = new List<string>();

            var wordsWithH = strings.Where(currentString => currentString.StartsWith("h"));

            var firstHWord = strings.First(currentString => currentString.StartsWith("h"));

            var transformed = strings.Select(currentString => $"{currentString} is dope");

            foreach (var currentString in strings)
            {
                Console.WriteLine($"hey {currentString}");
            }

            var alphabetWords = new Dictionary<char, string>();
            alphabetWords.Add('a', "apple");

            alphabetWords['a'] = "sup";

            foreach (var key_value in alphabetWords)
            {
                Console.WriteLine(key_value.Key);
                Console.WriteLine(key_value.Value);
            }


            var hashSet = new HashSet<Animal>();
            var Tom = (new Animal { Age = 12, Color = "Brown", Name = "Tom", Type = "Cat" });
            var Jerry = (new Animal { Age = 3, Color = "Black", Name = "Jerry", Type = "Mouse" });
            hashSet.Add(Tom);
            hashSet.Add(Jerry);
            
        }

    }

    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
    }
}

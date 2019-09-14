using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public bool isPalindrome { get; set; }

        public bool Check(string input)
        {
            List<char> originalString = new List<char>();
            Regex pattern = new Regex(@"[^\d,! ]");
            foreach (char letter in input)
            {
                if (pattern.IsMatch(letter.ToString()))
                {
                    originalString.Add(Char.ToLower(letter));
                }
            }
            List<char> reversedString = new List<char>(originalString);
            reversedString.Reverse();
            if (reversedString.SequenceEqual(originalString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConversion
{
    public class RomanNumeralConverter
    {

        public char BuildNumberList(string stringNumber, int letterPosition)
        {
            List<char> numbersList = new List<char>();
            foreach (char character in stringNumber)
            {
                numbersList.Add(character);
            }
            return numbersList[letterPosition];
        }

        public string ThousandsPlace(string stringNumber, int index)
        {
            var number = BuildNumberList(stringNumber, index);
            switch (char.ToString(number))
            {
                case "1":
                    return "M";
                case "2":
                    return "MM";
                case "3":
                    return "MMM";
                default:
                    return "whoops, invalid number";
            }
            return "";
        }
        public string HundredsPlace(string stringNumber, int index)
        {
            var number = BuildNumberList(stringNumber, index);
            switch (char.ToString(number))
            {
                case "1":
                    return "C";
                case "2":
                    return "CC";
                case "3":
                    return "CCC";
                case "4":
                    return "CD";
                case "5":
                    return "D";
                case "6":
                    return "DC";
                case "7":
                    return "DCC";
                case "8":
                    return "DCCC";
                case "9":
                    return "CM";
                case "0":
                    return "";
                default:
                    return "whoops, invalid number";
            }
        }
        public string TensPlace(string stringNumber, int index)
        {
            var number = BuildNumberList(stringNumber, index);
            switch (char.ToString(number))
            {
                case "1":
                    return "X";
                case "2":
                    return "XX";
                case "3":
                    return "XXX";
                case "4":
                    return "XL";
                case "5":
                    return "L";
                case "6":
                    return "LX";
                case "7":
                    return "LXX";
                case "8":
                    return "LXXX";
                case "9":
                    return "XC";
                case "0":
                    return "";
                default:
                    return "whoops, invalid number";
            }
        }
        public string OnesPlace(string stringNumber, int index)
        {
            var number = BuildNumberList(stringNumber, index);
            switch (char.ToString(number))
            {
                case "1":
                    return "I";
                case "2":
                    return "II";
                case "3":
                    return "III";
                case "4":
                    return "IV";
                case "5":
                    return "V";
                case "6":
                    return "VI";
                case "7":
                    return "VII";
                case "8":
                    return "VIII";
                case "9":
                    return "IX";
                case "0":
                    return "";
                default:
                    return "whoops, invalid number";
            }
        }


        public string fourDigitConversion(string numberString)
        {
            var output = ThousandsPlace(numberString, 0) + HundredsPlace(numberString, 1) + TensPlace(numberString, 2) + OnesPlace(numberString, 3);
            return output;
        }
        public string threeDigitConversion(string numberString)
        {
            var output = HundredsPlace(numberString, 0) + TensPlace(numberString, 1) + OnesPlace(numberString, 2);
            return output;
        }
        public string twoDigitConversion(string numberString)
        {
            var output = TensPlace(numberString, 0) + OnesPlace(numberString, 1);
            return output;
        }
        public string singleDigitConversion(string numberString)
        {
            var output = OnesPlace(numberString, 0);
            return output;
        }



        public string Convert(int numberToConvert)
        {
            string stringOfNumberToConvert = numberToConvert.ToString();
            if (stringOfNumberToConvert.Length == 4)
            {
                var output = fourDigitConversion(stringOfNumberToConvert);
                return output;
            }
            else if (stringOfNumberToConvert.Length == 3)
            {
                var output = threeDigitConversion(stringOfNumberToConvert);
                return output;
            }
            if (stringOfNumberToConvert.Length == 2)
            {
                var output = twoDigitConversion(stringOfNumberToConvert);
                return output;
            }
            if (stringOfNumberToConvert.Length == 1)
            {
                var output = singleDigitConversion(stringOfNumberToConvert);
                return output;
            }
            else
            {
                return "cant convert, please enter a valid number between 0 and 3999";
            }
        }

    }
}

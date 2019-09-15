using System;
using Xunit;

namespace RomanNumeralConversion.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CheckOneDigit()
        {
            var number = 7;
            var RomanNumeralConverter = new RomanNumeralConverter();

            var output = RomanNumeralConverter.Convert(number);

            Assert.Equal("VII", output);
        }

        [Fact]
        public void CheckTwoDigit()
        {
            var number = 99;
            var RomanNumeralConverter = new RomanNumeralConverter();

            var output = RomanNumeralConverter.Convert(number);

            Assert.Equal("XCIX", output);
        }

        [Fact]
        public void CheckThreeDigit()
        {
            var number = 356;
            var RomanNumeralConverter = new RomanNumeralConverter();

            var output = RomanNumeralConverter.Convert(number);

            Assert.Equal("CCCLVI", output);
        }

        [Fact]
        public void CheckFourDigit()
        {
            var number = 1024;
            var RomanNumeralConverter = new RomanNumeralConverter();

            var output = RomanNumeralConverter.Convert(number);

            Assert.Equal("MXXIV", output);
        }

    }
}

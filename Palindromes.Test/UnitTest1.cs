using System;
using Xunit;

namespace Palindromes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var input = "Stars";
            var palindromeChecker = new PalindromeChecker();

            //Act
            var isPalindrome = palindromeChecker.Check(input);

            //Assert
            Assert.False(isPalindrome);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            var input = "O, a kak Uwakov lil vo kawu kakao!";
            var palindromeChecker = new PalindromeChecker();

            //Act
            var isPalindrome = palindromeChecker.Check(input);

            //Assert
            Assert.True(isPalindrome);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            var input = "Some men interpret nine memos";
            var palindromeChecker = new PalindromeChecker();

            //Act
            var isPalindrome = palindromeChecker.Check(input);

            //Assert
            Assert.True(isPalindrome);
        }
    }
}

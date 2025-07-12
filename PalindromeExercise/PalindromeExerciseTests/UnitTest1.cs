using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] 
        public void Test1(string str, bool expected)
        {
            var word = new WordSmith();
            
            var result = word.IsAPalindrome(str);

            Assert.Equal(expected, result);


        }

        [Theory]
        [InlineData("hello", false)]
        public void Test2(string str, bool expected)
        {
            var word = new WordSmith();

            var result = word.IsAPalindrome(str);

            Assert.Equal(expected, result);

        }
    }
}

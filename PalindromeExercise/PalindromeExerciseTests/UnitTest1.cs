using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData( "bob", true)]
        [InlineData("gag", true)]
        public void Test1(string str, bool expected)
        {
            var word = new WordSmith();

            var result = word.IsAPalindrome(str);

            Assert.Equal(expected, result);


        }
    }
}

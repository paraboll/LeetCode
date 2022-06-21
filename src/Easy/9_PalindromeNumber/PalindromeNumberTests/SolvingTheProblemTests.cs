using PalindromeNumber;
using System;
using Xunit;

namespace PalindromeNumberTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void TwoSum1()
        {
            int target = 14341;
            var isPalindrome = SolvingTheProblem.IsPalindrome(target);

            Assert.False(isPalindrome);
        }
    }
}

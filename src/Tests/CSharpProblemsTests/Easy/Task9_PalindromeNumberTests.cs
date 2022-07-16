using CSharpProblems.Easy;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task9_PalindromeNumberTests
    {
        [Fact]
        public void TwoSum1()
        {
            int target = 14341;
            var isPalindrome = new Task9_PalindromeNumber().IsPalindrome(target);

            Assert.False(isPalindrome);
        }
    }
}

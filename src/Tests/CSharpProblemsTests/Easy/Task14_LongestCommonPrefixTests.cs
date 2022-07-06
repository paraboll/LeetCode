using CSharpProblems.Easy;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task14_LongestCommonPrefixTests
    {
        [Fact]
        public void LongestCommonPrefix()
        {
            var strs = new string[] { "flower", "flow", "flight" };
            var prefix = Task14_LongestCommonPrefix.LongestCommonPrefix(strs);

            Assert.Equal("fl", prefix);
        }

        [Fact]
        public void LongestCommonPrefix1()
        {
            var strs = new string[] { "dog", "racecar", "car" };
            var prefix = Task14_LongestCommonPrefix.LongestCommonPrefix(strs);

            Assert.Equal(string.Empty, prefix);
        }
    }
}

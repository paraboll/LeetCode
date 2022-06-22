using LongestCommonPrefix;
using System;
using Xunit;

namespace LongestCommonPrefixTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void LongestCommonPrefix()
        {
            var strs = new string[] { "flower", "flow", "flight" };
            var prefix = SolvingTheProblem.LongestCommonPrefix(strs);

            Assert.Equal("fl", prefix);
        }

        [Fact]
        public void LongestCommonPrefix1()
        {
            var strs = new string[] { "dog", "racecar", "car" };
            var prefix = SolvingTheProblem.LongestCommonPrefix(strs);

            Assert.Equal(string.Empty, prefix);
        }
    }
}

using CSharpProblems.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Medium
{
    public class Task3_LongestSubstringWithoutRepeatingCharactersTests
    {
        [Fact]
        public void LengthOfLongestSubstring()
        {
            var s = "abcabcbb";

            var countSymbol = new Task3_LongestSubstringWithoutRepeatingCharacters()
                                        .LengthOfLongestSubstring(s);

            Assert.Equal(3, countSymbol);
        }

        [Fact]
        public void LengthOfLongestSubstring1()
        {
            var s = "bbbbb";

            var countSymbol = new Task3_LongestSubstringWithoutRepeatingCharacters()
                                        .LengthOfLongestSubstring(s);

            Assert.Equal(1, countSymbol);
        }

        [Fact]
        public void LengthOfLongestSubstring2()
        {
            var s = "pwwkew";

            var countSymbol = new Task3_LongestSubstringWithoutRepeatingCharacters()
                                        .LengthOfLongestSubstring(s);

            Assert.Equal(3, countSymbol);
        }
    }
}

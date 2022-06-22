using RomanToInteger;
using System;
using Xunit;

namespace RomanToIntegerTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void RomanToInt()
        {
            var romanNumber = "MCMXCIV";

            var decNumber = SolvingTheProblem.RomanToInt(romanNumber);
            Assert.Equal(1994, decNumber);
        }

        [Fact]
        public void RomanToInt1()
        {
            var romanNumber = "LVIII";

            var decNumber = SolvingTheProblem.RomanToInt(romanNumber);
            Assert.Equal(58, decNumber);
        }

        [Fact]
        public void RomanToInt2()
        {
            var romanNumber = "III";

            var decNumber = SolvingTheProblem.RomanToInt(romanNumber);
            Assert.Equal(3, decNumber);
        }
    }
}

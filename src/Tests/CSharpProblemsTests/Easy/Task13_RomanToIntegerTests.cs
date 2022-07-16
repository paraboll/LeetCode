using CSharpProblems.Easy;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task13_RomanToIntegerTests
    {
        [Fact]
        public void RomanToInt()
        {
            var romanNumber = "MCMXCIV";

            var decNumber = new Task13_RomanToInteger().RomanToInt(romanNumber);
            Assert.Equal(1994, decNumber);
        }

        [Fact]
        public void RomanToInt1()
        {
            var romanNumber = "LVIII";

            var decNumber = new Task13_RomanToInteger().RomanToInt(romanNumber);
            Assert.Equal(58, decNumber);
        }

        [Fact]
        public void RomanToInt2()
        {
            var romanNumber = "III";

            var decNumber = new Task13_RomanToInteger().RomanToInt(romanNumber);
            Assert.Equal(3, decNumber);
        }
    }
}

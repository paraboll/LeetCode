using System;
using Xunit;
using AmountToBePaid;

namespace AmountToBePaidTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void ProductSum()
        {
            var prices = new int[] { 1, 1, 1, 2, 2, 3, 4 };

            var amountToBePaid = new SolvingTheProblem().ProductSum(prices);
            Assert.Equal(13, amountToBePaid);
        }

        [Fact]
        public void ProductSum1()
        {
            var prices = new int[] { 1, 1, 1, 2, 2, 3, 4, 5,5,5, 1, 4};

            var amountToBePaid = new SolvingTheProblem().ProductSum(prices);
            Assert.Equal(28, amountToBePaid);
        }
    }
}

using System;
using TwoSum;
using Xunit;

namespace TwoSumTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void TwoSum1()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            int target = 7;
            var numbers = SolvingTheProblem.TwoSum(array, target);

            Assert.Equal(numbers, new int[] { 1, 4 });
        }

        [Fact]
        public void TwoSum2()
        {
            var array = new int[] { 3,3 };
            int target = 6;
            var numbers = SolvingTheProblem.TwoSum(array, target);

            Assert.Equal(numbers, new int[] { 0, 1 });
        }

        [Fact]
        public void TwoSum3()
        {
            var array = new int[] { 3, 2, 4 };
            int target = 6;
            var numbers = SolvingTheProblem.TwoSumAlgoritm(array, target);

            Assert.Equal(numbers, new int[] { 1, 2 });
        }

        [Fact]
        public void TwoSum4()
        {
            var array = new int[] { 3, 2, 4 };
            int target = 6;

            var numbers = SolvingTheProblem.TwoPassHashTable(array, target);

            Assert.Equal(numbers, new int[] { 1, 2 });
        }

        [Fact]
        public void TwoSum5()
        {
            var array = new int[] { 3, 3 };
            int target = 6;

            var numbers = SolvingTheProblem.TwoPassHashTable(array, target);

            Assert.Equal(numbers, new int[] { 0, 1 });
        }

        [Fact]
        public void TwoSum6()
        {
            var array = new int[] { 2, 7, 11, 15 };
            int target = 9;

            var numbers = SolvingTheProblem.TwoPassHashTable(array, target);

            Assert.Equal(numbers, new int[] { 0, 1 });
        }
    }
}

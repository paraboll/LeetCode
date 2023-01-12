using CSharpProblems.Easy;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task1_TwoSumTests
    {
        [Fact]
        public void TwoSum1()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            int target = 7;
            var numbers = new DS1_Day2_Task1_TwoSum().TwoSum(array, target);

            Assert.Equal(numbers, new int[] { 1, 4 });
        }

        [Fact]
        public void TwoSum2()
        {
            var array = new int[] { 3, 3 };
            int target = 6;
            var numbers = new DS1_Day2_Task1_TwoSum().TwoSum(array, target);

            Assert.Equal(numbers, new int[] { 0, 1 });
        }

        [Fact]
        public void TwoSum3()
        {
            var array = new int[] { 3, 2, 4 };
            int target = 6;
            var numbers = new DS1_Day2_Task1_TwoSum().TwoSumAlgoritm(array, target);

            Assert.Equal(numbers, new int[] { 1, 2 });
        }

        [Fact]
        public void TwoSum4()
        {
            var array = new int[] { 3, 2, 4 };
            int target = 6;

            var numbers = new DS1_Day2_Task1_TwoSum().TwoPassHashTable(array, target);

            Assert.Equal(numbers, new int[] { 1, 2 });
        }

        [Fact]
        public void TwoSum5()
        {
            var array = new int[] { 3, 3 };
            int target = 6;

            var numbers = new DS1_Day2_Task1_TwoSum().TwoPassHashTable(array, target);

            Assert.Equal(numbers, new int[] { 0, 1 });
        }

        [Fact]
        public void TwoSum6()
        {
            var array = new int[] { 2, 7, 11, 15 };
            int target = 9;

            var numbers = new DS1_Day2_Task1_TwoSum().TwoPassHashTable(array, target);

            Assert.Equal(numbers, new int[] { 0, 1 });
        }

        [Fact]
        public void TwoSum7()
        {
            var array = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 9;

            var numbers = new DS1_Day2_Task1_TwoSum().TwoPassHashTable1(array, target);

            Assert.Equal(numbers, new int[] { 5, 11 });
        }

        [Fact]
        public void TwoSum8()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            int target = 7;
            var numbers = new DS1_Day2_Task1_TwoSum().BruteForce(array, target);

            Assert.Equal(numbers, new int[] { 1, 4 });
        }
    }
}

using CSharpProblems.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Medium
{
    public class Task53_MaximumSubarrayTests
    {
        [Fact]
        public void MaxSubArray1()
        {
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            var result = new Task53_MaximumSubarray()
                                .MaxSubArray(nums);

            Assert.Equal(6, result);
        }

        [Fact]
        public void MaxSubArray2()
        {
            var nums = new int[] { 5, 4, -1, 7, 8 };

            var result = new Task53_MaximumSubarray()
                                .MaxSubArray(nums);

            Assert.Equal(23, result);
        }
    }
}

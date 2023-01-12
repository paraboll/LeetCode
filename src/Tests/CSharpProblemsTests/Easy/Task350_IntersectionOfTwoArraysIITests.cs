using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task350_IntersectionOfTwoArraysIITests
    {
        [Fact]
        public void Intersect1()
        {
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };

            var resultNums = new int[] { 2, 2 };

            var result = new DS1_Day3_Task350_IntersectionOfTwoArraysII()
                                .Intersect(nums1, nums2);

            Assert.Equal(resultNums, result);
        }

        [Fact]
        public void Intersect2()
        {
            var nums1 = new int[] { 4, 9, 5 };
            var nums2 = new int[] { 9, 4, 9, 8, 4 };

            var resultNums = new int[] { 4, 9 };

            var result = new DS1_Day3_Task350_IntersectionOfTwoArraysII()
                                .Intersect(nums1, nums2);

            Assert.Equal(resultNums, result);
        }
    }
}

using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task88_MergeSortedArrayTests
    {
        [Fact]
        public void Merge()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            int m = 3, n = 3;

            new Task88_MergeSortedArray()
                    .Merge(nums1, m, nums2, n);

            var ansver = new int[] { 1, 2, 2, 3, 5, 6 };
            Assert.Equal(ansver, nums1);
        }
    }
}

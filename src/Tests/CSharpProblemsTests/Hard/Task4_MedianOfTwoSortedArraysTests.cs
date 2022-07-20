using CSharpProblems.Hard;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Hard
{
    public class Task4_MedianOfTwoSortedArraysTests
    {
        [Fact]
        public void FindMedianSortedArrays()
        {
            var num1 = new int[] { 1, 3 };
            var num2 = new int[] { 2 };

            var result = new Task4_MedianOfTwoSortedArrays()
                                .FindMedianSortedArrays_LongAlgoritm(num1, num2);

            Assert.Equal(2.00000, result);
        }

        [Fact]
        public void FindMedianSortedArrays1()
        {
            var num1 = new int[] { 1, 2 };
            var num2 = new int[] { 3, 4 };

            var result = new Task4_MedianOfTwoSortedArrays()
                                .FindMedianSortedArrays_LongAlgoritm(num1, num2);

            Assert.Equal(2.50000, result);
        }
    }
}

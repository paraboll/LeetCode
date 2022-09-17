using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task121_BestTimeToBuyAndSellStockTests
    {
        [Fact]
        public void MaxProfit1()
        {
            var nums1 = new int[] { 7, 1, 5, 3, 6, 4 };

            var result = new Task121_BestTimeToBuyAndSellStock()
                                .MaxProfit(nums1);

            Assert.Equal(5, result);
        }

        [Fact]
        public void MaxProfit2()
        {
            var nums1 = new int[] { 7,6,4,3,1 };

            var result = new Task121_BestTimeToBuyAndSellStock()
                                .MaxProfit(nums1);

            Assert.Equal(0, result);
        }
    }
}

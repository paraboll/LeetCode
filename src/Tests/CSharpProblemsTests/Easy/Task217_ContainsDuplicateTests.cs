using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpProblemsTests.Easy
{
    public class Task217_ContainsDuplicateTests
    {
        [Fact]
        public void ContainsDuplicate1()
        {
            var nums = new int[] { 1, 2, 3, 1 };

            var result = new DS1_Day1_Task217_ContainsDuplicate()
                                .ContainsDuplicate(nums);

            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicate2()
        {
            var nums = new int[] {1,2,3,4 };

            var result = new DS1_Day1_Task217_ContainsDuplicate()
                                .ContainsDuplicate(nums);

            Assert.False(result);
        }


        [Fact]
        public void ContainsDuplicate3()
        {
            var nums = new int[] { 1,1,1,3,3,4,3,2,4,2 };

            var result = new DS1_Day1_Task217_ContainsDuplicate()
                                .ContainsDuplicate(nums);

            Assert.True(result);
        }


    }
}

using CSharpProblems.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static CSharpProblems.Easy.Task21_MergeTwoSortedLists;

namespace CSharpProblemsTests.Easy
{
    public class Task21_MergeTwoSortedListsTests
    {
        [Fact]
        public void Task21_MergeTwoSortedLists()
        {
            var num1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            var num2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

            var resultNum = new ListNode(1,
                                new ListNode(1,
                                    new ListNode(2,
                                        new ListNode(3,
                                            new ListNode(4,
                                                new ListNode(4, null))))));

            var result = new Task21_MergeTwoSortedLists()
                                .MergeTwoLists1(num1, num2);

            Assert.Equal(resultNum, result);
                                
        }
    }
}

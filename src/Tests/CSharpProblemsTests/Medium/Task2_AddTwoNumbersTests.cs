using CSharpProblems.Medium;
using Xunit;
using static CSharpProblems.Medium.Task2_AddTwoNumbers;

namespace CSharpProblemsTests.Medium
{
    public class Task2_AddTwoNumbersTests
    {
        [Fact]
        public void AddTwoNumbers()
        {
            var listNode1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            var listNode2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            var listNodeResult = new Task2_AddTwoNumbers().AddTwoNumbers(listNode1, listNode2);

            var result = new ListNode(7, new ListNode(0, new ListNode(8, null)));

            while (result != null)
            {
                Assert.Equal(result.val, listNodeResult.val);

                result = result.next;
                listNodeResult = listNodeResult.next;
            }     
        }

        [Fact]
        public void AddTwoNumbers1()
        {
            var listNode1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            var listNode2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            var listNodeResult = new Task2_AddTwoNumbers().addTwoNumbers1(listNode1, listNode2);

            var result = new ListNode(7, new ListNode(0, new ListNode(8, null)));

            while (result != null)
            {
                Assert.Equal(result.val, listNodeResult.val);

                result = result.next;
                listNodeResult = listNodeResult.next;
            }
        }

        [Fact]
        public void AddTwoNumbers2()
        {
            var listNode1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            var listNode2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            var listNodeResult = new Task2_AddTwoNumbers().addTwoNumbers2(listNode1, listNode2);

            var result = new ListNode(7, new ListNode(0, new ListNode(8, null)));

            while (result != null)
            {
                Assert.Equal(result.val, listNodeResult.val);

                result = result.next;
                listNodeResult = listNodeResult.next;
            }
        }
    }
}

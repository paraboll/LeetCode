using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    //21. Merge Two Sorted Lists

    //You are given the heads of two sorted 
    //    linked lists list1 and list2.

    //Merge the two lists in a one sorted list.The list should be 
    //made by splicing together the nodes of the first two lists.

    //Return the head of the merged linked list.

    //Example 1:
    //Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
    //Output: [1,1,2,3,4,4]

    //Example 2:
    //Input: list1 = [], list2 = []
    //Output: []

    //Example 3:
    //Input: list1 = [], list2 = [0]
    //Output: [0]

    //Constraints:

    //The number of nodes in both lists is in the range [0, 50].
    //    -100 <= Node.val <= 100
    //    Both list1 and list2 are sorted in non-decreasing order.

    public class Task21_MergeTwoSortedLists
    {
        public class ListNode {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null) 
            {
                this.val = val;
                this.next = next;
            }
      }

        //Runtime: 146 ms, faster than 23.65% of C# online submissions for Merge Two Sorted Lists.
        //Memory Usage: 38 MB, less than 68.94% of C# online submissions for Merge Two Sorted Lists.
        public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode(0); //указатель на 1 элемент.
            ListNode head = result;             //Указатель на текущий элемент.
            while (list1 != null || list2 != null)
            {
                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        head.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        head.next = list2;
                        list2 = list2.next;
                    }
                }
                else if (list1 != null)
                {
                    head.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    head.next = list2;
                    list2 = list2.next;
                }
                head = head.next;
            }
            return result.next;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Medium
{
    //2. Add Two Numbers

    //You are given two non-empty linked lists representing two non-negative integers.
    //The digits are stored in reverse order, and each of their nodes contains a single digit.
    //Add the two numbers and return the sum as a linked list.

    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    //Example 1:
    //Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
    //Output: [7,0,8]
    //Explanation: 342 + 465 = 807.

    //Example 2:
    //Input: l1 = [0], l2 = [0]
    //Output: [0]

    //Example 3:
    //Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
    //Output: [8,9,9,9,0,0,0,1]

    //Constraints:

    //    The number of nodes in each linked list is in the range [1, 100].
	   // 0 <= Node.val <= 9

    //    It is guaranteed that the list represents a number that does not have leading zeros.

    public class Task2_AddTwoNumbers
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode res = new ListNode(0);
            ListNode cur = res;

            while (l1 != null || l2 != null)
            {
                int val = 0;
                if (l1 != null && l2 != null)
                {
                    val = l1.val + l2.val + carry;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 != null)
                {
                    val = l1.val + carry;
                    l1 = l1.next;
                }
                else
                {
                    val = l2.val + carry;
                    l2 = l2.next;
                }

                cur.next = new ListNode(val % 10);
                carry = val / 10;
                cur = cur.next;
            }

            if (carry == 1)
                cur.next = new ListNode(1);

            return res.next;
        }

        public ListNode addTwoNumbers1(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode cur1 = l1, cur2 = l2;
            ListNode dummy = new ListNode(0);
            ListNode cur = dummy;
            ListNode temp = null;

            while (cur1 != null && cur2 != null)
            {
                int sum = cur1.val + cur2.val + carry;
                temp = new ListNode(sum % 10);
                carry = sum / 10;
                cur.next = temp;
                cur = cur.next;
                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            ListNode node = cur1 != null ? cur1 : cur2;
            while (node != null)
            {
                temp = new ListNode((node.val + carry) % 10);
                carry = (node.val + carry) / 10;
                cur.next = temp;
                cur = cur.next;
                node = node.next;
            }
            if (carry == 1)
            {
                cur.next = new ListNode(1);
            }

            return dummy.next;
        }

        public ListNode addTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode cur = dummy;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int sum = 0;
                if (l1 != null && l2 != null)
                {
                    sum = l1.val + l2.val + carry;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 != null)
                {
                    sum = l1.val + carry;
                    l1 = l1.next;
                }
                else
                {
                    sum = l2.val + carry;
                    l2 = l2.next;
                }

                cur.next = new ListNode(sum % 10);
                carry = sum / 10;
                cur = cur.next;
            }

            if (carry == 1) 
                cur.next = new ListNode(1);

            return dummy.next;
        }
    }
}

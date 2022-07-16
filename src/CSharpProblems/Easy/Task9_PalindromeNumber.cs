using System;

namespace CSharpProblems.Easy
{
    //Given an integer x, return true if x is palindrome integer.
    //An integer is a palindrome when it reads the same backward as forward.
    //For example, 121 is a palindrome while 123 is not.

    //Example 1:
    //Input: x = 121
    //Output: true
    //Explanation: 121 reads as 121 from left to right and from right to left.

    //Example 2:
    //Input: x = -121
    //Output: false
    //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

    //Example 3:
    //Input: x = 10
    //Output: false
    //Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

    //Constraints:
	   // -231 <= x <= 231 - 1

    //Follow up: Could you solve it without converting the integer to a string?

    public class Task9_PalindromeNumber
    {
        // Runtime: 82 ms, faster than 26.51% of C# online submissions for Palindrome Number.
        // Memory Usage: 28.4 MB, less than 59.90% of C# online submissions for Palindrome Number.
        public bool IsPalindrome(int x)
        {

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }

        //Runtime: 72 ms, faster than 42.99% of C# online submissions for Palindrome Number.
        //Memory Usage: 28.3 MB, less than 69.28% of C# online submissions for Palindrome Number.
        public bool isPalindrome1(int num)
        {
            if (num < 0) return false;
            int reversed = 0, remainder, original = num;
            while (num != 0)
            {
                remainder = num % 10;
                reversed = reversed * 10 + remainder;
                num /= 10;
            }

            return original == reversed;
        }

        //Runtime: 103 ms, faster than 7.11% of C# online submissions for Palindrome Number.
        //Memory Usage: 28.2 MB, less than 77.45% of C# online submissions for Palindrome Number.
        public bool isPalindrome3(int x)
        {
            var str = x.ToString();
            int start = 0;
            int end = str.Length - 1;

            while (end > start)
            {
                if (str[start++] != str[end--]) return false;
            }

            return true;
        }
    }
}

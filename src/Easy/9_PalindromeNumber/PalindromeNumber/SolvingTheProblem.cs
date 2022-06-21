using System;

namespace PalindromeNumber
{
    public static class SolvingTheProblem
    {

        // Runtime: 82 ms, faster than 26.51% of C# online submissions for Palindrome Number.
        // Memory Usage: 28.4 MB, less than 59.90% of C# online submissions for Palindrome Number.
        public static bool IsPalindrome(int x)
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
        public static bool isPalindrome1(int num)
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
        public static bool isPalindrome3(int x)
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

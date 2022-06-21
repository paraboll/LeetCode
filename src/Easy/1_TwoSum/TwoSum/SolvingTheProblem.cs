using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    public static class SolvingTheProblem
    {

        // Runtime: 368 ms, faster than 6.16% of C# online submissions for Two Sum.
        // Memory Usage: 42.6 MB, less than 87.83% of C# online submissions for Two Sum.
        public static int[] TwoSum(int[] nums, int target) // O(n2)
        {
            for (int firstNumberIndex = 0; firstNumberIndex < nums.Length; firstNumberIndex++)
            {
                var firstNumber = nums[firstNumberIndex];
                var secondNumber = target - firstNumber;

                for (int secondNumberIndex = 0; secondNumberIndex < nums.Length; secondNumberIndex++)
                {
                    if (secondNumber == nums[secondNumberIndex] && firstNumberIndex != secondNumberIndex)
                    {
                        return new int[] { firstNumberIndex, secondNumberIndex };
                    }
                }
            }

            return null;
        }

        //Runtime: 342 ms, faster than 8.46% of C# online submissions for Two Sum.
        //Memory Usage: 42.6 MB, less than 87.83% of C# online submissions for Two Sum.
        public static int[] TwoSumAlgoritm(int[] nums, int target) // O(n2)
        {
            for (int firstNumberIndex = 0; firstNumberIndex < nums.Length; firstNumberIndex++)
            {
                for (int secondNumberIndex = 0; secondNumberIndex < nums.Length; secondNumberIndex++)
                {
                    if ((target - nums[firstNumberIndex]) == nums[secondNumberIndex] && firstNumberIndex != secondNumberIndex)
                    {
                        return new int[] { firstNumberIndex, secondNumberIndex };
                    }
                }
            }

            return null;
        }

        //решения с сайта.
        //Runtime: 291 ms, faster than 18.17% of C# online submissions for Two Sum.
        //Memory Usage: 42.8 MB, less than 73.39% of C# online submissions for Two Sum
        public static int[] BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        public static int[] TwoPassHashTable(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i], i); //два ключа одинаковых.
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }
            // In case there is no solution, we'll just return null
            return null;
        }
    }
}

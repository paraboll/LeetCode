using System.Collections.Generic;

namespace CSharpProblems.Easy
{
    //1.Two Sum

    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    //Example 1:
    //Input: nums = [2, 7, 11, 15], target = 9
    //Output:[0,1]
    //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

    //Example 2:
    //Input: nums = [3, 2, 4], target = 6
    //Output:[1,2]

    //Example 3:
    //Input: nums = [3, 3], target = 6
    //Output:[0,1]

    //Constraints:

    //  2 <= nums.length <= 104
    //  - 109 <= nums[i] <= 109
    //  - 109 <= target <= 109
    //Only one valid answer exists.

    //Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

    public class Task1_TwoSum
    {
        // Runtime: 368 ms, faster than 6.16% of C# online submissions for Two Sum.
        // Memory Usage: 42.6 MB, less than 87.83% of C# online submissions for Two Sum.
        public int[] TwoSum(int[] nums, int target) // O(n2)
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
        public int[] TwoSumAlgoritm(int[] nums, int target) // O(n2)
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
        public int[] BruteForce(int[] nums, int target)
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

        public int[] TwoPassHashTable(int[] nums, int target)
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

        public int[] TwoPassHashTable1(int[] nums, int target)
        {
            var mapper = new Dictionary<int, int>();
            int numLength = nums.Length;
            for (int i = 0; i < numLength; i++)
            {
                if (!mapper.ContainsKey(target - nums[i]))
                {
                    mapper.Add(nums[i], i);
                }
                else
                {
                    return new int[] { i, mapper[target - nums[i]] };
                }
            }
            return null;
        }
    }
}

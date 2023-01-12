using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Medium
{
    public class DS1_Day1_Task53_MaximumSubarray
    {
        //TODO: расписать итерации для этих 2х методов.

        //Kadane's Algorithm (Optimization of Above DP solution): Since we only
        //  need DP[i-1] to calculate DP[i]. There is no need of storing all values,
        //  we can get our solution done by one variable as well.

        // Runtime: 206 ms, faster than 96.42% of C# online submissions for Maximum Subarray.
        // Memory Usage: 50 MB, less than 11.15% of C# online submissions for Maximum Subarray.
        public int MaxSubArray(int[] nums)
        {
            int subArrayMax = 0;
            int allArrayMax = int.MinValue;

            foreach (var num in nums)
            {
                subArrayMax = Math.Max(subArrayMax + num, num);
                allArrayMax = Math.Max(allArrayMax, subArrayMax);
            }

            return allArrayMax;
        }

        public int MaxSubArrayGoodRead(int[] nums)
        {
            int subArrayMax = nums[0];
            int allArrayMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var nextSumValue =  nums[i] + subArrayMax;
                subArrayMax = Math.Max(nextSumValue, nums[i]);
                allArrayMax = Math.Max(allArrayMax, subArrayMax);
            }

            return allArrayMax;
        }

        // nums: -2, 1, -3, 4, -1, 2, 1, -5, 4 
        // allArrayMax: 6  [4, -1, 2, 1]

        // | Итерация | i | nums[i] | subArrayMax | nextSumValue | allArrayMax |
        // + -------- + - + ------- + ----------- + -----------  + ----------- +
        // |    0     | 1 |    1    |     -2      |       -      |     -2      | <-- перед началом 1 итерации
        // |    1     | 1 |    1    |      1      |      -1      |      1      | <-- в конце первой итерации
        // |    2     | 2 |   -3    |     -2      |      -2      |      1      |
        // |    3     | 3 |    4    |      4      |       2      |      4      |
        // |    4     | 4 |   -1    |      3      |       3      |      4      |
        // |    5     | 5 |    2    |      5      |       5      |      5      |
        // |    6     | 6 |    1    |      6      |       6      |      6      |
        // |    7     | 7 |   -5    |      1      |       1      |      6      |
        // |    8     | 8 |    4    |      5      |       5      |      6      |
        // + -------- + - + ------- + ----------- + -----------  + ----------- +

        public int maxSubArray1(int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
                max = Math.Max(max, nums[i]); // sum of array 0'th to i'th index

                for (int j = 1; j <= i; j++)
                {
                    int sum = nums[i] - nums[j - 1]; // sum of array j'th to i'th index
                    max = Math.Max(max, sum);
                }
            }

            return max;
        }
    }
}

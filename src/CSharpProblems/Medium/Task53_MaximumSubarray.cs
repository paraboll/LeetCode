using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Medium
{
    public class Task53_MaximumSubarray
    {
        //TODO: расписать итерации для этих 2х методов.

        //Kadane's Algorithm (Optimization of Above DP solution): Since we only
        //  need DP[i-1] to calculate DP[i]. There is no need of storing all values,
        //  we can get our solution done by one variable as well.

        // Runtime: 206 ms, faster than 96.42% of C# online submissions for Maximum Subarray.
        // Memory Usage: 50 MB, less than 11.15% of C# online submissions for Maximum Subarray.
        public int MaxSubArray(int[] nums)
        {
            int curr = 0;
            int max = int.MinValue;

            foreach (var num in nums)
            {
                curr = Math.Max(curr + num, num);
                max = Math.Max(max, curr);
            }

            return max;
        }

        public int maxSubArray1(int[] nums)
        {
            int n = nums.Length;
            int max = nums[0];

            for (int i = 1; i < n; i++)
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

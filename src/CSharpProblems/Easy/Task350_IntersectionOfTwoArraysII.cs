using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    //350. Intersection of Two Arrays II

    //Given two integer arrays nums1 and nums2, return an array 
    //    of their intersection.Each element in the result must 
    //    appear as many times as it shows in both arrays 
    //    and you may return the result in any order.

    //Example 1:
    //Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
    //Output: [2,2]

    //Example 2:
    //Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4] 
    //Output: [4,9]
    //Explanation: [9,4] is also accepted.

    //Constraints:
    //    1 <= nums1.length, nums2.length <= 1000
    //    0 <= nums1[i], nums2[i] <= 1000
    public class Task350_IntersectionOfTwoArraysII
    {
        // Runtime: 267 ms, faster than 11.21% of C# online submissions for Intersection of Two Arrays II.
        // Memory Usage: 41.4 MB, less than 95.44% of C# online submissions for Intersection of Two Arrays II.
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var output = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {

                    if (nums1[i] == nums2[j])
                    {
                        output.Add(nums1[i]);
                        nums2[j] = int.MaxValue;
                        break;
                    }
                }
            }

            return output.ToArray();
        }

        // nums1: 4, 9, 5;
        // nums2: 9, 4, 9, 8, 4

        // resultNums: 4, 9 

        // | Итерация | i | nums1[i] | j | nums[j] | outPut |
        // + -------- + - + -------- + - + ------- + ------ +
        // |    0     | 0 |    -     | 0 |    -    |   -    |
        // |    1     | 0 |    4     | 0 |    9    |   []   |
        // |    2     | 0 |    4     | 1 |    4    |  [4]   |
        // |    3     | 1 |    9     | 0 |    9    | [4, 9] |
        // |    4     | 2 |    5     | 0 |    9    | [4, 9] |
        // |   ...                                          |
        // |    n     | 2 |    5     | 5 |    4    | [4, 9] |
        // + -------- + - + -------- + - + ------- + ------ +

        // Обратить внимание на num2[j] = int.MaxValue

    }
}

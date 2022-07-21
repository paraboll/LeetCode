using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    // 217. Contains Duplicate

    //Given an integer array nums, return true if any 
    //    value appears at least twice in the array, 
    //    and return false if every element is distinct.


    //Example 1:
    //Input: nums = [1,2,3,1]
    //   Output: true

    //Example 2:
    //Input: nums = [1,2,3,4]
    //    Output: false

    //Example 3:
    //Input: nums = [1,1,1,3,3,4,3,2,4,2]
    //    Output: true
 
    //Constraints:

    //1 <= nums.length <= 105
    //-109 <= nums[i] <= 109

    public class Task217_ContainsDuplicate
    {
        // Runtime: 326 ms, faster than 34.24% of C# online submissions for Contains Duplicate.
        // Memory Usage: 48.4 MB, less than 27.34% of C# online submissions for Contains Duplicate.
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }

                set.Add(nums[i]);
            }

            return false;
        }

        // Runtime: 262 ms, faster than 57.63% of C# online submissions for Contains Duplicate.
        // Memory Usage: 48.3 MB, less than 28.40% of C# online submissions for Contains Duplicate.
        public bool ContainsDuplicate1(int[] nums)
        {
            var set = new SortedSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }

                set.Add(nums[i]);
            }

            return false;
        }

        // Runtime: 344 ms, faster than 29.29% of C# online submissions for Contains Duplicate.
        // Memory Usage: 47.2 MB, less than 52.56% of C# online submissions for Contains Duplicate.
        public bool ContainsDuplicate2(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) return true;
            }
            return false;
        }
    }


}

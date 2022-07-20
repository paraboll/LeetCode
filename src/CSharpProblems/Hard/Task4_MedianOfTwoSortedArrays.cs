using System;
using System.Collections.Generic;
using System.Text;

//НЕРАЗОБРАЛ.
namespace CSharpProblems.Hard
{
    //4. Median of Two Sorted Arrays

    //Given two sorted arrays nums1 and nums2 of size m and n respectively, 
    //return the median of the two sorted arrays.
    //The overall run time complexity should be O(log (m+n)).

    //Example 1:
    //Input: nums1 = [1,3], nums2 = [2]
    //Output: 2.00000
    //Explanation: merged array = [1, 2, 3] and median is 2.

    //Example 2:
    //Input: nums1 = [1,2], nums2 = [3,4]
    //Output: 2.50000
    //Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.

    //Constraints:

    //nums1.length == m
    //nums2.length == n
    //    0 <= m <= 1000
    //    0 <= n <= 1000
    //    1 <= m + n <= 2000
    //    -106 <= nums1[i], nums2[i] <= 106  
    public class Task4_MedianOfTwoSortedArrays
    {
        // Runtime: 166 ms, faster than 39.21% of C# online submissions for Median of Two Sorted Arrays.
        // Memory Usage: 44.8 MB, less than 17.63% of C# online submissions for Median of Two Sorted Arrays.
        public double FindMedianSortedArrays_LongAlgoritm(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length != 0)
            {
                int index = nums2.Length / 2;
                if (nums2.Length % 2 == 0)
                    return (nums2[index - 1] + nums2[index]) / 2.0d;
                else
                    return nums2[index];
            }
            if (nums2.Length == 0 && nums1.Length != 0)
            {
                int index = nums1.Length / 2;
                if (nums1.Length % 2 == 0)
                    return (nums1[index - 1] + nums1[index]) / 2.0d;
                else
                    return nums1[index];
            }
            if (nums2.Length == 0 && nums1.Length == 0)
            {
                return 0.0d;
            }

            var list = new List<int>();
            int index1 = 0;
            int index2 = 0;
            while (index1 < nums1.Length && index2 < nums2.Length)
            {
                if (nums1[index1] <= nums2[index2])
                {
                    list.Add(nums1[index1]);
                    index1++;
                }
                else
                {
                    list.Add(nums2[index2]);
                    index2++;
                }
            }

            if (index1 == nums1.Length)
            {
                for (; index2 < nums2.Length; index2++)
                {
                    list.Add(nums2[index2]);
                }
            }
            else
            {
                for (; index1 < nums1.Length; index1++)
                {
                    list.Add(nums1[index1]);
                }
            }

            int size = list.Count;
            if (size % 2 == 0)
            {
                return (list[size / 2 - 1] + list[size / 2]) / 2.0d;
            }
            else
            {
                return list[size / 2];
            }
        }

        // Runtime: 149 ms, faster than 56.50% of C# online submissions for Median of Two Sorted Arrays.
        // Memory Usage: 39.8 MB, less than 45.70% of C# online submissions for Median of Two Sorted Arrays.
        public double FindMedianSortedArrays_SimplifiedLongAlgoritm(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            int index1 = 0;
            int index2 = 0;
            while (index1 < nums1.Length && index2 < nums2.Length)
            {
                if (nums1[index1] <= nums2[index2])
                {
                    list.Add(nums1[index1]);
                    index1++;
                }
                else
                {
                    list.Add(nums2[index2]);
                    index2++;
                }
            }

            if (index1 == nums1.Length)
            {
                for (; index2 < nums2.Length; index2++)
                {
                    list.Add(nums2[index2]);
                }
            }
            else
            {
                for (; index1 < nums1.Length; index1++)
                {
                    list.Add(nums1[index1]);
                }
            }

            int size = list.Count;
            if (size % 2 == 0)
            {
                return (list[size / 2 - 1] + list[size / 2]) / 2.0d;
            }
            else
            {
                return list[size / 2];
            }
        }
        
        public double FindMedianSortedArrays_Method1(int[] nums1, int[] nums2)
        {
            return 0;
        }

        // Runtime: 138 ms, faster than 66.94% of C# online submissions for Median of Two Sorted Arrays.
        // Memory Usage: 39.6 MB, less than 69.77% of C# online submissions for Median of Two Sorted Arrays.
        // разобрать.
        public double findMedianSortedArrays_Amazon_BinarySearch(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            if (len2 < len1) return findMedianSortedArrays_Amazon_BinarySearch(nums2, nums1);

            int k = (len1 + len2 + 1) / 2;
            int l = 0, r = len1, m1 = 0;
            while (l < r)
            {
                m1 = l + (r - l) / 2;
                int m2 = k - m1;
                if (nums1[m1] < nums2[m2 - 1]) l = m1 + 1;
                else r = m1;
            }

            m1 = l;
            int c1 = Math.Max(m1 <= 0 ? int.MinValue : nums1[m1 - 1],
                              k - m1 <= 0 ? int.MinValue : nums2[k - m1 - 1]);
            
            if ((len1 + len2) % 2 == 1)
                return (double)c1;

            int c2 = Math.Min(m1 >= len1 ? int.MaxValue : nums1[m1],
                              k - m1 >= len2 ? int.MaxValue : nums2[k - m1]);

            return (double)(c1 + c2) / 2;
        }
    }
}

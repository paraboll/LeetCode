using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Medium
{
    //3. Longest Substring Without Repeating Characters

    //Given a string s, find the length of the longest substring without repeating characters.

    //Example 1:
    //Input: s = "abcabcbb"
    //Output: 3
    //Explanation: The answer is "abc", with the length of 3.

    //Example 2:
    //Input: s = "bbbbb"
    //Output: 1
    //Explanation: The answer is "b", with the length of 1.

    //Example 3:
    //Input: s = "pwwkew"
    //Output: 3
    //Explanation: The answer is "wke", with the length of 3.
    //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

    //Constraints:
    //    0 <= s.length <= 5 * 104
    //    s consists of English letters, digits, symbols and spaces.

    public class Task3_LongestSubstringWithoutRepeatingCharacters
    {
        //Runtime: 158 ms, faster than 27.68% of C# online submissions for Longest Substring Without Repeating Characters.
        //Memory Usage: 37 MB, less than 38.70% of C# online submissions for Longest Substring Without Repeating Characters.
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0) return 0;

            int indexOfRemote = 0, indexOfAddition = 0, maxSequenceLength = 0;
            var symbolSet = new HashSet<char>();

            char[] arr = s.ToCharArray();
            while (indexOfAddition < arr.Length && indexOfRemote < arr.Length)
            {
                if (!symbolSet.Contains(arr[indexOfAddition]))
                    symbolSet.Add(arr[indexOfAddition++]);
                else
                    symbolSet.Remove(arr[indexOfRemote++]);

                maxSequenceLength = Math.Max(maxSequenceLength, symbolSet.Count);
            }

            return maxSequenceLength;
        }


        //  Строка: pwwkew.
        //  Цель symbolSet -> wke  

        // + -------- + ------ + --------- + --------------- + --------------- + ----------------- +    
        // | Итерация | Символ | symbolSet | indexOfAddition | indexOfAddition | maxSequenceLength |         
        // + -------- + ------ + --------- + --------------- + --------------- + ----------------- +
        // |    0     |   -    |     -     |       0         |       0         |         0         |
        // |    1     |   p    |   p       |       1         |       0         |         1         |
        // |    2     |   w    |   pw      |       2         |       0         |         2         |
        // |    3     |   w    |    w      |       2         |       1         |         2         |
        // |    4     |   w    |    -      |       2         |       2         |         2         |
        // |    5     |   w    |    w      |       3         |       2         |         2         |
        // |    6     |   k    |    wk     |       4         |       2         |         2         |
        // |    7     |   e    |    wke    |       5         |       3         |         3         |
        // |    8     |   w    |     ke    |       5         |       3         |         3         |
        // |    9     |   w    |     kew   |       6         |       3         |         3         |
        // + -------- + ------ + --------- + --------------- + --------------- + ----------------- +
    }
}

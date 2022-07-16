using System;

namespace CSharpProblems.Easy
{
    //Write a function to find the longest common prefix string amongst an array of strings.
    //If there is no common prefix, return an empty string "".

    //Example 1:
    //Input: strs = ["flower", "flow", "flight"]
    //Output: "fl"

    //Example 2:
    //Input: strs = ["dog", "racecar", "car"]
    //Output: ""
    //Explanation: There is no common prefix among the input strings.

    //Constraints:
	   // 1 <= strs.length <= 200
	   // 0 <= strs[i].length <= 200

    //    strs[i] consists of only lowercase English letters.

    public class Task14_LongestCommonPrefix
    {
		//Runtime: 151 ms, faster than 32.09% of C# online submissions for Longest Common Prefix.
		//Memory Usage: 38.5 MB, less than 74.14% of C# online submissions for Longest Common Prefix.
		public string LongestCommonPrefix(string[] strs)
		{
			if (0 == strs.Length) return "";        //Check the boundary conditions.
			if (strs[0].Length == 0) return "";

			var result = strs[0];
			for (int i = 1; i < strs.Length; i++)
			{
				if (strs[i].Equals("")) return "";
				int len = Math.Min(result.Length, strs[i].Length);  //Compare current result and next String.
				result = result.Substring(0, len);
				for (int j = 0; j < len; j++)
				{
					if (result[j] != strs[i][j])
					{
						result = result.Substring(0, j);
						break;
					}
				}
			}
			return result;
		}
	}
}

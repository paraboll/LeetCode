using System;

namespace LongestCommonPrefix
{
    public static class SolvingTheProblem
    {
        public static string LongestCommonPrefix(string[] strs)
        {
			if (0 == strs.Length) return "";        //Check the boundary conditions.
			if (strs[0].Length == 0) return "";
			String result = strs[0];
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

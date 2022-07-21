using System.Collections.Generic;

namespace CSharpProblems.Easy
{
    //20. Valid Parentheses

    //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
    //determine if the input string is valid.

    //An input string is valid if:

    //Open brackets must be closed by the same type of brackets.
    //Open brackets must be closed in the correct order.

    public class Task20_ValidParentheses
    {
        //Runtime: 141 ms, faster than 12.93% of C# online submissions for Valid Parentheses.
        //Memory Usage: 36.4 MB, less than 87.89% of C# online submissions for Valid Parentheses.
        public bool IsValid(string s)
        {
            if (s.Length == 0) return true;

            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char char_i = s[i];
                if (char_i == '(' || char_i == '{' || char_i == '[')
                {
                    stack.Push(char_i);
                    continue;
                }

                if (stack.Count == 0) return false;
                if (char_i == ')' && stack.Pop() == '(')
                {
                    continue;
                }
                else if (char_i == ']' && stack.Pop() == '[')
                {
                    continue;
                }
                else if (char_i == '}' && stack.Pop() == '{')
                {
                    continue;
                }

                else return false;
            }

            if(stack.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}

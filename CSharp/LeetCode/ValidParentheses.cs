using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/valid-parentheses/
        /// 简单，左括号就入栈，右括号就出栈并比对。最后栈必须为空
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            Stack<char> stack=new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        var l = stack.Pop();
                        if ((c == ')' && l == '(') || (c == ']' && l == '[') || (c == '}' && l == '{'))
                        {
                            continue;
                        }
                    }
                    return false;
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}

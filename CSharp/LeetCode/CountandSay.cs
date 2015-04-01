using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/count-and-say/
        /// 递归模拟
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public String CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            var prev = CountAndSay(n - 1);
            int count = 1;
            char prevChar = prev[0];
            if (prev.Length == 1)
            {
                return count.ToString() + prevChar;
            }
            StringBuilder sb=new StringBuilder();
            for (int i = 1; i < prev.Length; i++)
            {
                var c = prev[i];
                if (c == prevChar)
                {
                    count++;
                }
                else
                {
                    sb.Append(count.ToString() + prevChar);
                    count = 1;
                    prevChar = c;
                }
                if (i == prev.Length - 1)//last one
                {
                    sb.Append(count.ToString() + c);
                }
            }
            return sb.ToString();
        }
    }
}

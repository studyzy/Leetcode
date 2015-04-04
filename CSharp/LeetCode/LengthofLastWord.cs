using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/length-of-last-word/
        /// 非常简单，从后开始，如果是字符就计数，如果是空格，就停止计数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLastWord(string s)
        {
            int len = s.Length;
            int max = 0;
            bool begin = false;
            for (int i = 0; i < len; i++)
            {
                char c = s[len - i - 1];
                if (c == ' ')
                {
                    if (begin)
                    break;
                }
                else
                {
                    begin = true;
                    max++;
                }
               
            }
            return max;
        }
    }
}

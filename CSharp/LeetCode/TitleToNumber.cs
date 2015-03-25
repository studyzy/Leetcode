using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int TitleToNumber(String s)
        {
            int result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                char c = s[s.Length - i - 1];
                int num = (c - 'A' + 1);
                int num2 = (int)Math.Pow(26, i);
                result += num * num2;
            }
            return result;
        }
    }
}

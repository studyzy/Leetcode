using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/valid-palindrome/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            StringBuilder sb=new StringBuilder();
            foreach (var c in s)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    sb.Append((char) (c + 32));//to lower
                }
                if (c >= 'a' && c <= 'z')
                {
                    sb.Append(c);
                }
                if (c >= '0' && c <= '9')
                {
                    sb.Append(c);
                }
            }
            return IsPalindromeString(sb.ToString());
        }

        private bool IsPalindromeString(string s)
        {
            int len = s.Length;
            for (var i = 0; i < len/2; i++)
            {
                if (s[i] != s[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

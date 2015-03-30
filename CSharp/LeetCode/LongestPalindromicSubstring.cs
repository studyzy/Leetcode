using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string LongestPalindrome(string s)
        {
            int maxLen = 1;
            string maxSubstring = "";
            int len = s.Length;
            if (len <= 1)
            {
                return s;
            }
            if (len == 2)
            {
                return (s[0] == s[1]) ? s : s[0].ToString();
                
            }
            if (len == 3)
            {
                if (s[0] == s[1] && s[1] != s[2])
                {
                    return s.Substring(0, 2);
                }
            }
            for (var i = 1; i < len - 1; i++)
            {
                var sub = GetPalindrome(s, i);
                if (sub.Length > maxLen)
                {
                    maxLen = sub.Length;
                    maxSubstring = sub;
                }
                if (s[i] == s[i + 1])
                {
                    //可能是偶数对称，重新按偶数对称计算
                    var evenSub = GetPalindromeEven(s, i);
                    if (evenSub.Length > maxLen)
                    {
                        maxLen = evenSub.Length;
                        maxSubstring = evenSub;
                    }
                }
            }
            return maxSubstring;
        }

        private string GetPalindrome(string s, int i)
        {
            int maxLen = Math.Min(i, s.Length - i-1);
            for (int j = 1; j <= maxLen; j++)
            {
                var a = s[i - j];
                var b = s[i + j];
                if (a != b)
                {
                    var sub = s.Substring(i - j + 1, (j - 1)*2 + 1);
                   
                    return sub;
                }
            }
            return s.Substring(i-maxLen,maxLen*2+1);
        }
        private string GetPalindromeEven(string s, int i)
        {
            int maxLen = Math.Min(i, s.Length - i - 2);
            for (int j = 1; j <= maxLen; j++)
            {
                var a = s[i - j];
                var b = s[i + 1 + j];
                if (a != b)
                {
                   
                    return s.Substring(i - j + 1, (j - 1) * 2 + 2);
                }
            }
            return s.Substring(i - maxLen, maxLen * 2 + 2);
        }
    }
}

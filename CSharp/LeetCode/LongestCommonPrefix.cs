using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/longest-common-prefix/
        /// 找到数组中最短的一个字符串长度，然后for循环，缓存第一个字符串的第i个字符，然后和其他字符串的第i个字符比，不相同的时候就返回。
        /// 如果都相同，那么就是返回最小长度的那么长的字符串
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            int minLen = strs[0].Length;
            foreach (var str in strs)
            {
                minLen = Math.Min(minLen, str.Length);
            }
            for (var i = 0; i < minLen; i++)
            {
                char c=strs[0][i];
                foreach (var str in strs)
                {
                    if (str[i] != c)
                    {
                        return str.Substring(0, i);
                    }
                }
            }
            return strs[0].Substring(0, minLen);
        }
    }
}

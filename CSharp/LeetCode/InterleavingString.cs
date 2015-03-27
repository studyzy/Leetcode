using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/interleaving-string/
        /// 好像很难做
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public bool IsInterleave(string s1, string s2, string s3)
        {
            int s1len = s1.Length;
            int s2len = s2.Length;
            int s3len = s3.Length;
            if (s1len + s2len != s3len)
            {
                return false;
            }
            if (s1len < s2len)//保证第一个字符串长，第二个字符串短
            {
                return IsInterleave(s2, s1, s3);
            }
            bool[] f=new bool[s2len+1];
            for (int i = 0; i <= s2len; i++)
            {
                f[i] = true;
            }
            for (int i = 1; i <= s2len; i++)
            {
                f[i] = (s2[i - 1] == s3[i - 1]) && f[i - 1];
            }
            for (int i = 1; i <= s1len; i++)
            {
                f[0] = s1[i - 1] == s3[i - 1] && f[0];
                for (int j = 1; j <= s2len; j++)
                {
                    f[j] = (s1[i - 1] == s3[i + j - 1] && f[j]) || (s2[j - 1] == s3[i + j - 1] && f[j - 1]);
                }
            }
            return f[s2len];
        }


    }
}

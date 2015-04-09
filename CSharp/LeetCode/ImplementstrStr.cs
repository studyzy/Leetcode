using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/implement-strstr/
        /// TODO 暴力解法会超时，只有采用最牛逼的KMP算法，参考：
        /// http://www.ruanyifeng.com/blog/2013/05/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm.html
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
            //for (var i = 0; i < haystack.Length; i++)
            //{
            //    int match = 0;
            //    for (var j = 0; j < needle.Length; j++)
            //    {
            //        if (i+j==haystack.Length||  haystack[i + j] != needle[j])
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            match++;
            //        }
            //    }
            //    if (match == needle.Length)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }
    }
}

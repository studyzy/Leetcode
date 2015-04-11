using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/compare-version-numbers/
        /// 这道题要注意后面有子版本的比没有的大。比如1.1>1
        /// </summary>
        /// <param name="version1"></param>
        /// <param name="version2"></param>
        /// <returns></returns>
        public int CompareVersion(string version1, string version2)
        {
            var v1Array = version1.Split('.');
            var v2Array = version2.Split('.');
            for (var i = 0; i < Math.Max(v1Array.Length, v2Array.Length); i++)
            {
                var v1 = 0;
                if (i < v1Array.Length)
                    v1 = Convert.ToInt32(v1Array[i]);
                var v2 = 0;
                if (i < v2Array.Length)
                    v2 = Convert.ToInt32(v2Array[i]);
                if (v1 > v2) return 1;
                if (v1 < v2) return -1;
            }
            return 0;
        }
    }
}

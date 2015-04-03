using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/longest-consecutive-sequence/
        /// TODO Timeout 了，杯具
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] num)
        {
            Dictionary<int,bool> hash=new Dictionary<int, bool>();
            int max = 1;
            foreach (var n in num)
            {
                hash[n] = true;
                //往右找连续的值
                int rightLen = 0;
                while (true)
                {
                    if(!hash.ContainsKey(n+(++rightLen))) break;
                }
                int leftLen = 0;
                //往左找连续的值
                while (true)
                {
                    if(!hash.ContainsKey(n-(++leftLen))) break;
                }
                max = Math.Max(max, leftLen + rightLen-1);
            }
            return max;
        }
    }
}

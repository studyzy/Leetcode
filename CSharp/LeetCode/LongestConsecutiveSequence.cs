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
		/// 问题解决，基本做到了O（n）的复杂度
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] num)
        {
            Dictionary<int,bool> hash=new Dictionary<int, bool>();

            foreach (var n in num)
            {
                hash[n] = false;

            }
			int max = 1;
			foreach (var n in num)
			{
				if (hash [n]) {
					continue;
				}
				hash[n] = true;
				//往右找连续的值
				int rightLen = 0;
				while (true)
				{
					int r = n + (++rightLen);
					if(!hash.ContainsKey(r)) break;
					hash [r] = true;
				}
				int leftLen = 0;
				//往左找连续的值
				while (true)
				{
					var l = n - (++leftLen);
					if(!hash.ContainsKey(l)) break;
					hash [l] = true;
				}
				max = Math.Max(max, leftLen + rightLen-1);
			}
            return max;
        }
    }
}

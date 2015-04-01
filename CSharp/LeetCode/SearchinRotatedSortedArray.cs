using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// TODO 其实不是很明白这道题想考啥
        /// </summary>
        /// <param name="A"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] A, int target)
        {
            if (A.Length == 0)
            {
                return -1;
            }
            int prev = A[0];
            if (prev == target)
            {
                return 0;
            }
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

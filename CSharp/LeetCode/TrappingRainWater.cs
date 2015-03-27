using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/trapping-rain-water/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Trap(int[] A)
        {
            int len = A.Length;
            if (len < 3)
            {
                return 0;
            }
            int count = 0;
           
            int leftHeight = 0;
            int rightHeight = Max(A,2, len);
            
            for (int i = 1; i < len-1; i++)//左边和右边都不会积水的
            {
                leftHeight = Math.Max(A[i - 1], leftHeight);
                if (A[i] == rightHeight)
                {
                    rightHeight = Max(A, i + 1, len);
                }
                int maxHeight = Math.Min(leftHeight, rightHeight);
                if(A[i]<maxHeight)
                count += maxHeight-A[i];//短板
            }
            return count;
        }

        private int Max(int[] A, int left, int right)
        {
            int min = 0;
            for (int i = left; i < right; i++)
            {
                min = Math.Max(A[i], min);
            }
            return min;
        }
    }
}

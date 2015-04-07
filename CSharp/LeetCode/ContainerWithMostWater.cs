using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(IList<int> height)
        {
            //TODO 以下算法虽然简单，但是算法复杂度为O(n^2)，会超时
            //int max = 0;
            //for (int i = 0; i < height.Count; i++)
            //{
            //    int left = height[i];
            //    for (int j = i+1; j < height.Count; j++)
            //    {
            //        int right = height[j];
            //        int area = (j - i)*Math.Min(left, right);
            //        max = Math.Max(max, area);
            //    }
            //}
            //return max;

            int max = 0;
            int left = 0;
            int right = height.Count - 1;
            while (left<right)
            {
              var h=  Math.Min(height[left], height[right]);
                max = Math.Max(max, h*(right - left));
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return max;

        }

    }
}

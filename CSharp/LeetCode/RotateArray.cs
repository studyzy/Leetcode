using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/rotate-array/
        /// TODO 这道题没做出来，需要学习
		/// ①将整个数组反转 
		///②将由分割点分割的两个数组分别反转 
		///即：1 2 3 4 5 6 7 -> 7 6 5 | 4 3 2 1 -> 5 6 7 | 1 2 3 4 
		///时间复杂度为O(n)，空间复杂度为O(1)。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
			var n=nums.Length;
			k = k % n;
			rev(nums, 0, n - 1);
			rev(nums, 0, k - 1);
			rev(nums, k, n - 1);
            
        }
		void rev(int[] num, int left, int right)
		{
			int temp;
			while (left < right)
			{
				temp = num[left];
				num[left++] = num[right];
				num[right--] = temp;
			}
		}
    }
}

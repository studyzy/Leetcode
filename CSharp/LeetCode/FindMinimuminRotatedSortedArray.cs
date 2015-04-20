using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
		/// TODO 执行效率不是很高，应该有更好的算法
		/// </summary>
		/// <returns>The minimum.</returns>
		/// <param name="nums">Nums.</param>
		public int FindMin(int[] nums) 
		{
			int t = nums [0];
			for (var i = 1; i < nums.Length; i++)
			{
				if (t < nums [i])
					continue;
				return nums [i];
			}
			return t;
		}
	}
}


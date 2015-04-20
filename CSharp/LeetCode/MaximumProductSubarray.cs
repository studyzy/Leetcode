using System;

namespace LeetCode
{
	public partial class Solution {
		/// <summary>
		/// https://leetcode.com/problems/maximum-product-subarray/
		/// 先按0分割数组，然后对没有0的数组，找左右两边的负数和负数出现的次数，如果负数出现次数为偶数，那么就返回所有数的乘积。
		/// 如果是奇数，那就看左边分割后的数字大还是右边的数字大。
		/// </summary>
		/// <returns>The product.</returns>
		/// <param name="nums">Nums.</param>
		public int MaxProduct(int[] nums) 
		{
			int max = Int32.MinValue;
			int len = nums.Length;
			if (len == 1)
			{
				return nums [0];
			}
			int leftidx = 0, rightidx = 0;

			for (var i = 0; i < len; i++)
			{
				
				if (nums [i] == 0)//此处必须分割
				{
					max = Math.Max (max, 0);
					rightidx = i - 1;
					max = Math.Max (max, MaxProduct (nums, leftidx, rightidx));
					leftidx = i + 1;
					continue;
				}
			}
			rightidx = len - 1;
			max = Math.Max (max, MaxProduct (nums, leftidx, rightidx));
			return max;
		}
		private int MaxProduct(int[] nums, int startp,int endp)
		{
			if (startp > endp)
			{
				return 0;
			}
			if (startp == endp)
			{
				return nums [startp];
			}
			int negative = 0;
			int total = 1;
			//string s = "";
			for (var i = startp; i <= endp; i++)
			{
				var n = nums [i];
				if (n < 0)
				{
					negative++;
				}
				total *= n;
			//	s=s+n+",";
			}
			//Console.WriteLine (s);
			if (negative % 2 == 0)
			{
				return total;
			}
			total = -total;
			int subtotal = 1;
			int breaknum = 0;
			for (var i = startp; i <= endp; i++)
			{
				var n = nums [i];
				if (n < 0)
				{
					breaknum = n;
					break;
				}
				subtotal *= n;
			}
			int max = Math.Max (subtotal, total / subtotal / -breaknum);
			subtotal = 1;
			for (var i = endp; i >= startp; i--)
			{
				var n = nums [i];
				if (n < 0)
				{
					breaknum = n;
					break;
				}
				subtotal *= n;
			}
			int max2=Math.Max (subtotal, total / subtotal / -breaknum);
			return Math.Max (max, max2);
		}
	}
}


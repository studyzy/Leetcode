using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/powx-n/
		/// 细节题，考虑1，0，-1这几个特殊的x
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="n">N.</param>
		public double Pow(double x, int n)
		{
			if (n == 0)
			{
				return 1;
			}
			if (n < 0)
			{
				x = 1 / x;
			}
			bool negative = false;
			if (x < 0)
			{
				negative = true;
				x = -x;
			}
			if (negative)
			{
				negative = n % 2 == 0 ? false : true;
			}
			double result = x;
			for (var i = 1; i <Math.Abs( (double)n); i++)
			{
				result *= x;
				if (result == 0.0||result==1)
					return negative?- result:result;
			}
			return negative?- result:result;

		}
	}
}


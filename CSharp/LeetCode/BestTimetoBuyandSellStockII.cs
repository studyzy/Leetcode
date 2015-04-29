using System;

namespace LeetCode
{
	public partial class Solution2 
	{
		/// <summary>
		/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
		/// 非常简单，计算每天和头一天比的利润，把所有正利润加起来即可
		/// </summary>
		/// <returns>The profit.</returns>
		/// <param name="prices">Prices.</param>
		public int MaxProfit(int[] prices) 
		{
			int len = prices.Length;
			if (len <= 1)
			{
				return 0;
			}

			int total = 0;
			for (var i = 1; i < len; i++)
			{
				if (prices [i] > prices [i - 1])
				{
					total += prices [i] - prices [i - 1];
				}

			}
			return total;
		}
	}
}


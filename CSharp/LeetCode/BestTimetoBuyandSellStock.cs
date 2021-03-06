﻿using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
		/// 做复杂了。
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

			// P[t] = max profit by selling before day t
			// then: P[t] = max{  (prices[t] - min(prices(0~t-1)), P[t-1], 0,}
			var max = 0;
			var minSoFar = prices[0];

			for (var i = 1; i < len; i++) {
				max = Math.Max(prices[i] - minSoFar, max);
				minSoFar = Math.Min(minSoFar, prices[i]);
			};

			return Math.Max(max,0);




//			int[] maxPrices = new int[len];
//			maxPrices [len - 1] = prices [len - 1];
//			for (var i = len-2; i >= 0; i--)
//			{
//				maxPrices [i] = Math.Max (maxPrices [i + 1], prices [i]);
//			}
//			int[] minPrices = new int[len];
//			minPrices [0] = prices [0];
//			for (var i = 1; i < len; i++)
//			{
//				minPrices [i] = Math.Min (minPrices [i - 1], prices [i]);
//			}
//			int max = int.MinValue;
//			for (var i = 0; i < len; i++)
//			{
//				max = Math.Max (max, maxPrices [i] - minPrices [i]);
//			}
//			return max;
		}
	}
}


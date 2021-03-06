﻿using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class BestTimetoBuyandSellStockIIUT:BaseUT
	{
		[TestCase("10,9,8,7,5,3,1",0)]
		[TestCase("10,20,30,0,5",25)]
		public void Test (string prices,int max)
		{
			int[] array = String2Int32Array (prices);
			Assert.AreEqual (Solution2.MaxProfit (array), max);
		}
	}
}


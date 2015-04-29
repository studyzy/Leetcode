using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class CountPrimesUT:BaseUT
	{
		[TestCase(1000,168)]
		[TestCase(1000000,78498)]
		[TestCase(1000000000,50847534)]
		[TestCase(0,0)]
		[TestCase(1,0)]
		[TestCase(2,0)]
		[TestCase(3,1)]
		[TestCase(4,2)]
		[TestCase(17,6)]//2,3,5,7,11,13
		public void Test (int n,int count)
		{
			DateTime start = DateTime.Now;
			var result = Solution.CountPrimes (n);
			Console.WriteLine (n+": " + (DateTime.Now - start).TotalSeconds);
			Assert.AreEqual (result, count);
		}
	}
}


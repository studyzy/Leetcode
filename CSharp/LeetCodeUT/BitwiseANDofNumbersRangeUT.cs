using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class BitwiseANDofNumbersRangeUT:BaseUT
	{
		[TestCase(5,7,4)]
		[TestCase(1,2,0)]
		[TestCase(3,4,0)]
		[TestCase(3,5,0)]
		[TestCase(3,6,0)]
		[TestCase(2,3,2)]
		[TestCase(2,4,0)]
		public void Test (int m,int n, int result)
		{
			Assert.AreEqual (Solution.RangeBitwiseAnd (m, n), result);
		}
	}
}


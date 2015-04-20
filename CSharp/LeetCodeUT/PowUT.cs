using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class PowUT:BaseUT
	{
		[TestCase(2,2)]
		[TestCase(2.1,-2)]
		[TestCase(2.2,10)]
		[TestCase(0.0001,9999999)]
		[TestCase(1.0001,9999999)]
		[TestCase(-1,9999999)]
		[TestCase(1,999999)]
		[TestCase(-13.62608, 3)]
		public void Test (double x,int n)
		{
			var result=Solution.Pow (x, n);
			var sysresult = Math.Pow (x, n);
			Assert.AreEqual (result, sysresult);
		}
	}
}


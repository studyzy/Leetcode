using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class MaximumProductSubarrayUT:BaseUT
	{
		[TestCase("1,2,3,0,4,-5",6)]
		[TestCase("1,2,3,0,4,-5,-6",120)]
		[TestCase("0,-1,0,-2,0,-3",0)]
		[TestCase("1,1,2,-2,-4,-3,7",84)]
		[TestCase("0,0,0,0",0)]
		[TestCase("-1",-1)]
		[TestCase("0,2",2)]
		public void Test (string str,int max)
		{
			var array = String2Int32Array (str);
			var result=Solution.MaxProduct (array);
			Assert.AreEqual (result, max);
		}
	}
}


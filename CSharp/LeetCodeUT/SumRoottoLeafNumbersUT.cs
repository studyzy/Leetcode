using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class SumRoottoLeafNumbersUT:BaseUT
	{
		[TestCase("1,2,3",25)]
		[TestCase("3",3)]
		public void Test (string tree,int sum)
		{
			var root = BuildTree (tree);
			var result = Solution.SumNumbers (root);
			Assert.AreEqual (result, sum);
		}
	}
}


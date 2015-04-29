using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class HappyNumberUT:BaseUT
	{
		[TestCase(19,true)]
		public void Test (int n,bool isHappy)
		{
			Assert.AreEqual (Solution.IsHappy (n), isHappy);
		}
	}
}


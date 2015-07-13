using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class DistinctSubsequencesUT:BaseUT
	{
		[TestCase("rabbbit","rabbit",3)]
		[TestCase("cccc","cc",6)]
		public void Test (string s,string t,int count)
		{
			Assert.AreEqual (Solution.NumDistinct (s, t), count);
		}
	}
}


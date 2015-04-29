using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class IsomorphicStringsUT:BaseUT
	{
		[TestCase("abcddd","xyzttt",true)]
		[TestCase("ab","aa",false)]
		public void Test (string s,string t,bool b)
		{
			Assert.AreEqual(Solution.IsIsomorphic(s,t),b);
		}
	}
}


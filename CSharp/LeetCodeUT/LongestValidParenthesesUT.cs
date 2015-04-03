using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class LongestValidParenthesesUT:BaseUT
	{
		[TestCase(")()())",4)]
		[TestCase("))))",0)]
		[TestCase("((((",0)]
		[TestCase("))))((",0)]
		[TestCase("()(()",2)]
		[TestCase("()(())",6)]
		public void Test (string str,int result)
		{
			int count=Solution.LongestValidParentheses (str);
			Assert.AreEqual (count, result);
		}
	}
}


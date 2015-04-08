using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class PalindromeNumberUT:BaseUT
	{
		[TestCase(12321,true)]
		[TestCase(123321,true)]
		[TestCase(120021,true)]
		[TestCase(-12321,false)]
		[TestCase(99999999,true)]
		public void Test (int num,bool ispal)
		{
			Assert.AreEqual (Solution.IsPalindrome (num), ispal);
		}
	}
}


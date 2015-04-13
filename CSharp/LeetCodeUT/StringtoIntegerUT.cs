using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class StringtoIntegerUT:BaseUT
	{
		[TestCase("123456",123456)]
		[TestCase("-123456",-123456)]
		[TestCase("123,456",123456)]
		[TestCase("0000",0)]
		[TestCase("0000100",100)]
		[TestCase("+-2",0)]
		[TestCase("  -0012a42",-12)]
		[TestCase("9223372036854775809",2147483647)]
		[TestCase("-2147483648",-2147483648)]
		public void Test (string str,int number)
		{
			var result = Solution.Atoi (str);
			Assert.AreEqual (result, number);
		}
	}
}


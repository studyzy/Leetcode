using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class ZigZagConversionUT:BaseUT
	{
		[TestCase("PAYPALISHIRING",3,"PAHNAPLSIIGYIR")]
		[TestCase("1234567890",5,"1928037465")]
		[TestCase("ABCD",2,"ACBD")]
		[TestCase("012345678",4,"061572483")]
		[TestCase("ABC",1,"ABC")]
		[TestCase("A",1,"A")]
		public void Test (string s,int n,string output)
		{
			var result = Solution.Convert (s, n);
			Assert.AreEqual (result, output);
		}
	}
}


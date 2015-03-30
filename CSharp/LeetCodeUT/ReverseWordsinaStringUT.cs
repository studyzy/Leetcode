using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class ReverseWordsinaStringUT:BaseUT
	{
		[TestCase("the sky is blue","blue is sky the")]
		public void Test (string input,string output)
		{
			var result=Solution.ReverseWords (input);
			Assert.AreEqual (output, result);
		}
	}
}


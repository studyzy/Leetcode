using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class PowerofTwoUT:BaseUT
	{
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(8)]
		[TestCase(1024)]
		[TestCase(2048)]
		public void TestTrue (int n)
		{
			Assert.IsTrue (Solution.IsPowerOfTwo (n));
		}
	}
}


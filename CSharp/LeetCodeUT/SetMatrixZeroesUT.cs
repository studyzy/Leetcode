using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class SetMatrixZeroesUT:BaseUT
	{
		[Test]
		public void Test1 ()
		{
			int[,] matrix = new int[,]{ { 1, 2, 3 }, { 0, int.MaxValue, 999 }, { int.MinValue, 0, 8888 } };
			Solution.SetZeroes (matrix);
			Assert.AreEqual (matrix [0, 0], 0);
			Assert.AreEqual (matrix [2, 0], 0);
			Assert.AreEqual (matrix [0, 1], 0);
			Assert.AreEqual (matrix [1, 1], 0);
		}
	}
}


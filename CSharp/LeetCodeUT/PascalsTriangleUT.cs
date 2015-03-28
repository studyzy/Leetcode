using System;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetCodeUT
{
	public class PascalsTriangleUT:BaseUT
	{
		[Test]
		public void Test ()
		{
			var list=Solution.Generate (5);
			foreach (var row in list) {
				Debug.WriteLine (string.Join (",", row));
			}
		}
	}
}


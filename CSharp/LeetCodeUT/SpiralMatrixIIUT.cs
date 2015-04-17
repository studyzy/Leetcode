using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeUT
{
	public class SpiralMatrixIIUT:BaseUT
	{
		[TestCase(1,"1")]
		[TestCase(2,"1,2,4,3")]
		[TestCase(3,"1,2,3,8,9,4,7,6,5")]
		public void Test (int n,string str)
		{
			var result=Solution.GenerateMatrix (n);
			List<int> list = new List<int> ();
			for (var i = 0; i < n; i++)
				for (var j = 0; j < n; j++)
				{
					list.Add (result [i, j]);
				}

			string s = String.Join (",", list);
			Assert.AreEqual (s, str);
		}
	}
}


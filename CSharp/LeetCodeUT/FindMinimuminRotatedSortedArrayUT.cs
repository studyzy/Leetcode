using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class FindMinimuminRotatedSortedArrayUT:BaseUT
	{
		[TestCase("4,5,6,7,1,2,3",1)]
		[TestCase("4,5,6,7,8,9,10",4)]
		[TestCase("1",1)]
		[TestCase("4,5,6,7,1",1)]
		public void Test (string array,int min)
		{
			int[] A=String2Int32Array(array);
			Assert.AreEqual (Solution.FindMin (A), min);
		}
	}
}


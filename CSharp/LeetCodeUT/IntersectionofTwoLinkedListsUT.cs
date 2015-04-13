using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class IntersectionofTwoLinkedListsUT:BaseUT
	{
		[TestCase("1,2,3,4,5","7,8,3,4,5","3,4,5")]
		[TestCase("1,2,3,4,5","3,4,5","3,4,5")]
		[TestCase("1,2,3,4,5","7,8,3,4,5,6","")]
		[TestCase("1,2,3,4,5,3,4","7,8,3,4,5,6,3,4","3,4")]
		public void Test (string listA,string listB,string intersectionList)
		{
			var na = BuildListNodes (listA);
			var nb = BuildListNodes (listB);
			var inter = Solution.GetIntersectionNode (na, nb);
			Assert.AreEqual (ListToString (inter), intersectionList);
		}
	}
}


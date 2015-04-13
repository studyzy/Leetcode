using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class WordBreakIIUT:BaseUT
	{
		[TestCase("catsanddog","cat,cats,and,sand,dog",2)]
		[TestCase("a","",0)]
		public void Test (string str,string dict,int resultCount)
		{
			var d = String2Set (dict);
			var result = Solution2.WordBreak (str, d);
			foreach (var s in result)
			{
				Console.WriteLine (s);
			}

			Assert.AreEqual (result.Count, resultCount);
		}
	}
}


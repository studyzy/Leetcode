using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class WordBreakUT:BaseUT
	{
		[TestCase("leetcode","leet,code",true)]
		[TestCase("leetcode","lee,tc,leet,code",true)]
		[TestCase("leetcodes","lee,tc,leet,code",false)]
		public void Test (string sentence,string dict,bool result)
		{
			var iset = String2Set (dict);
			Assert.AreEqual (Solution.WordBreak (sentence, iset), result);
		}
	}
}


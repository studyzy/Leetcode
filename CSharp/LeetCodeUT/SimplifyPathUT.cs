using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class SimplifyPathUT:BaseUT
	{
		[TestCase("/a/./b/../../c/","/c")]
		[TestCase("/a/./b//c/","/a/b/c")]
		public void Test (string path,string simple)
		{
			Assert.AreEqual (Solution.SimplifyPath (path), simple);
		}
	}
}


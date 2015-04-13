using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class BinaryTreeLevelOrderTraversalUT:BaseUT
	{
		[TestCase("3,9,20,#,#,15,7",3)]
		public void Test (string tree,int levels)
		{
			var root = BuildTree (tree);
			var result=Solution.LevelOrder (root);
			PrintListList (result);
			Assert.AreEqual (result.Count, levels);
		}
	}
}


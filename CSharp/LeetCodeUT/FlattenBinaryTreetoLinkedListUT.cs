using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class FlattenBinaryTreetoLinkedListUT:BaseUT
	{
		[TestCase("1,2,5,3,4,#,6","1,#,2,#,3,#,4,#,5,#,6")]
		public void Test (string tree,string result)
		{
			var root = BuildTree (tree);
			Solution.Flatten (root);
			var treeString = Tree2String (root);
			Console.WriteLine (treeString);
			Assert.AreEqual (treeString, result);
		}
	}
}


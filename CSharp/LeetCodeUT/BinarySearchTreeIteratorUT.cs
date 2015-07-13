using System;
using LeetCode;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class BinarySearchTreeIteratorUT:BaseUT
	{
		[TestCase("8,3,10,1,6,#,14,#,#,4,7,13","1,3,4,6,7,8,10,13,14,")]
		[TestCase("1","1,")]
		public void Test (string tree,string resultList)
		{
			var root =	BuildTree (tree);
			BSTIterator bst = new BSTIterator (root);
			StringBuilder sb = new StringBuilder ();
			while (bst.HasNext ())
			{
				//Console.WriteLine (bst.Next ());
				sb.Append (bst.Next () + ",");
			}
			Assert.AreEqual (sb.ToString (), resultList);
		}
	}
}


using System;
using NUnit.Framework;
using System.Diagnostics;
using System.Text;

namespace LeetCodeUT
{
	public class RemoveDuplicatesfromSortedArrayUT:BaseUT
	{
		[TestCase("1,1,1",1,"1")]
		[TestCase("1,1,2",2,"1,2")]
		[TestCase("1,1,1,1,2",2,"1,2")]
		[TestCase("1,2,2",2,"1,2")]
		[TestCase("1,1,2,2",2,"1,2")]
		[TestCase("1,2,4,8",4,"1,2,4,8")]
		[TestCase("1,1,2,3",3,"1,2,3")]
		public void Test (string input,int len,string output)
		{
			var array=String2Int32Array( input);
			var resultLen= Solution2.RemoveDuplicates(array);
			Assert.AreEqual (resultLen, len);
			StringBuilder sb = new StringBuilder ();
			for (var i = 0; i < resultLen; i++)
			{
				sb.Append (array [i]);
				sb.Append (",");
			}
			Assert.AreEqual (sb.ToString (), output + ",");

		}
	}
}


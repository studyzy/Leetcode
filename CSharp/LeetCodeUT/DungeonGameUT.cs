using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class DungeonGameUT:BaseUT
	{
		[Test]
		public void Test1 ()
		{
			int[,] dungeon=new [,]{{-2,-3,3},{-5,-10,1},{10,30,-5}};
			var result=	Solution.CalculateMinimumHP (dungeon);

			for (var i = 0; i < dungeon.Length; i++)
			{
				Console.Write (dungeon [i / 3, i % 3]+",");
				if (i % 3 == 2)
				{
					Console.WriteLine ("");
				}
			}
			Assert.AreEqual (result, 7);
		}
	}
}


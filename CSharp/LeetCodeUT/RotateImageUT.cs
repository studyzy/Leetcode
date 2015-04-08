using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class RotateImageUT:BaseUT
	{
		[Test]
		public void Test1 ()
		{

			int a = 123;
			int b = 456;
			a ^= b;
			b ^= a;
			a ^= b;
			Console.WriteLine (a + "," + b);

			var img = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			Solution.Rotate (img);
			for (var i = 0; i < img.Length; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine ("");
				}
				Console.Write (img [i / 3, i % 3]);
			}
		}
	}
}


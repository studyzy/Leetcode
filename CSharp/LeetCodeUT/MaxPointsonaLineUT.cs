using System;
using NUnit.Framework;
using LeetCode;
using System.Collections.Generic;

namespace LeetCodeUT
{
	public class MaxPointsonaLineUT:BaseUT
	{
		[Test]
		public void Test ()
		{
			var points = new List<Point>{ new Point (0, 0), new Point (1, 1), new Point (2, 2), new Point (1, 2) };
			Assert.AreEqual (Solution.MaxPoints (points.ToArray()), 3);
			points.Add (new Point (0, 10));
			points.Add (new Point (0, -10));
			points.Add (new Point (0, 12345));
			Assert.AreEqual (Solution.MaxPoints (points.ToArray()), 4);
		}
		[Test]
		public void Test2SamePoint()
		{
			var points = new List<Point>{ new Point (0, 0), new Point (1, 1), new Point (0, 0) };
			Assert.AreEqual (Solution.MaxPoints (points.ToArray()), 3);
		}
		[Test]
		public void Test3SamePoint()
		{
			var points = new List<Point>{ new Point (0, 0), new Point (0, 0), new Point (0, 0) };
			Assert.AreEqual (Solution.MaxPoints (points.ToArray()), 3);
		}
	}
}


using System;
using System.Collections.Generic;

namespace LeetCode
{
	

 
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/max-points-on-a-line/
		/// 两两组合，计算斜率，对于某个点，如果其他点只要斜率相同就是在同一条直线上。
		/// 需要注意的是点可能是重合的。
		/// </summary>
		/// <returns>The points.</returns>
		/// <param name="points">Points.</param>
		public int MaxPoints(Point[] points) 
		{
			
			if (points.Length < 3)
			{
				return points.Length;
			}
			int max = 0;
			for (var i = 0; i < points.Length; i++)
			{
				Dictionary<double,int> dic = new Dictionary<double, int> ();
				var p1 = points [i];
				int samePointCount = 0;
				for (var j = i + 1; j < points.Length; j++)
				{
					var p2 = points [j];
					var y = p2.y - p1.y;
					var x = p2.x - p1.x;
					if (x == 0 && y == 0)//same point
					{
						samePointCount++;
						continue;
					}
					double result = double.MaxValue;
					if (x != 0)
					{
						result = y * 1.0 / x;
					}
					if (dic.ContainsKey (result))
					{
						dic [result] = dic [result] + 1;
					}
					else
					{
						dic [result] = 2;
					}
				}
				if (dic.Count == 0)
				{
					max = Math.Max (max, samePointCount + 1);
				}
				foreach (var v in dic.Values)
				{
					max = Math.Max (max, v+samePointCount);
				}
			}


			return max;
		}
	}
}


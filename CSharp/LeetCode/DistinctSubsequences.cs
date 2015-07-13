using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution
	{
		/// <summary>
		/// https://leetcode.com/problems/distinct-subsequences/
		/// </summary>
		/// <returns>The distinct.</returns>
		/// <param name="s">S.</param>
		/// <param name="t">T.</param>
		public int NumDistinct(string s, string t) 
		{
			var f=new int[t.Length+1];
			f [0] = 1;
			for (var i = 0; i < s.Length; i++)
			{
				for (var j = t.Length-1; j >=0; j--)
				{
					f [j + 1] += s [i] == t [j] ? f [j] : 0;
				}
			}
			return f [t.Length];
		}
	}
}


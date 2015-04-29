using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution2 {
		/// <summary>
		/// https://leetcode.com/problems/word-break-ii/
		/// TODO 这道题太难了，需要用到动态规划算法，需要进一步学习
		/// </summary>
		/// <returns>The break.</returns>
		/// <param name="s">S.</param>
		/// <param name="dict">Dict.</param>
		public IList<String> WordBreak(string s, ISet<string> dict)
		{
			List<string>[] f = new List<string>[s.Length + 1];
			f [0] = new List<string>();

			for (int i=1;i<=s.Length;i++)
			{
				for (int j = i - 1; j >= 0; j--)
				{
					var sub = s.Substring (j, i - j);
					if (f [j]!=null && dict.Contains (sub))
					{
						if (f [i] == null)
						{
							f [i] = new List<string> ();
						}
						if (f [j].Count == 0)
						{
							f [i].Add (sub);
						}
						else
						{
							foreach (var str in f[j])
							{
								f [i].Add (str + " " + sub);
							}
						}

					}
				}
			}

			var result= f [s.Length];
			if (result == null)
			{
				result = new List<string> ();
			}
			return result;
		}
	}
}


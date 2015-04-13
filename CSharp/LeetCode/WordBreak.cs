using System;
using System.Text;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution 
	{
		
		/// <summary>
		/// https://leetcode.com/problems/word-break/
		/// 如果采用递归的方法暴力解决，虽然可以解决，但是会超时。
		/// 应该使用动态规划算法，用一个布尔数组保存每个字符之前的字符串是否能够Break。
		/// </summary>
		/// <returns><c>true</c>, if break was worded, <c>false</c> otherwise.</returns>
		/// <param name="s">S.</param>
		/// <param name="dict">Dict.</param>
		public bool WordBreak(string s, ISet<string> dict) 
		{
			bool[] f = new bool[s.Length + 1];
			f [0] = true;

			for (int i=1;i<=s.Length;i++)
			{
				for (int j = i - 1; j >= 0; j--)
				{
					var sub = s.Substring (j, i - j);
					if (f [j] && dict.Contains (sub))
					{
						f [i] = true;
						break;
					}
				}
			}
			return f[s.Length];
		}
	}
}


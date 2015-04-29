using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/isomorphic-strings/
		/// 使用一个Dictionary来保存Mapping关系，随时判断字段中是否存在重复。有重复的Key或者Value，那么就是False。
		/// </summary>
		/// <returns><c>true</c> if this instance is isomorphic the specified s t; otherwise, <c>false</c>.</returns>
		/// <param name="s">S.</param>
		/// <param name="t">T.</param>
		public bool IsIsomorphic(string s, string t) 
		{
			if (s.Length != t.Length)
			{
				return false;
			}
			var dic = new Dictionary<char,char> ();
			for (var i = 0; i < s.Length; i++)
			{
				var c = s [i];
				var v = t [i];
				if (dic.ContainsKey (c) )
				{
					if(dic [c] != v)
					return false;
				}
				else
				{
					if (dic.ContainsValue (v))
						return false;
					dic [c] = v;
				}
			}

			return true;
		}
	}
}


using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution {
		public int LengthOfLongestSubstring(string s) 
		{
			//TODO 以下算法虽然思路是对的，但是写法有问题，无法通过长字符串的测试，不应该递归
			#region Bad performance
//			IList<char> dic=new List<char>();
//			for (var i = 0; i < s.Length; i++)
//			{
//				char c = s [i];
//				if (dic.Contains (c))
//				{
//					var sub = s.Substring (s.IndexOf (c) + 1);
//
//					return Math.Max (i, LengthOfLongestSubstring (sub));
//				}
//				dic.Add (c);
//
//			}
//			return s.Length;

			#endregion

			//IList<char> dic=new List<char>();
			const int ARRAY_LEN=255;
			int[] dic=new int[ARRAY_LEN];
			for (var i = 0; i < ARRAY_LEN; i++)
			{
				dic [i] = -1;
			}
			int start = 0;
			int max = 0;
			for (var i = 0; i < s.Length; i++)
			{
				var c = s [i];
				if (dic[c]>=start)//也就是说dic里面不是-1，已经被赋值过，而且这个值在start位置之后出现，判断为重复
				{
					int len = i - start;
					max = Math.Max (max, len);
					start = dic [c] + 1;
				}
				dic [c] = i;
			}
			max = Math.Max (max, s.Length - start);
			return max;
		}
	}
}


using System;
using System.Text;

namespace LeetCode
{
	public partial class Solution {
		/// <summary>
		/// https://leetcode.com/problems/zigzag-conversion/
		/// 这道题出的很烂，举得例子太差劲了，以至于误解其意思。实际的例子应该是
		/// A   I
		/// B  HJ
		/// C G K O
		/// DF  LN
		/// E   M
		/// 实际就是找每个位置的数学规律，找到了，然后就好做了。
		/// </summary>
		/// <param name="s">S.</param>
		/// <param name="nRows">N rows.</param>
		public string Convert1(String s, int nRows) 
		{
			int max = nRows;
			int min = max - 2;
			min = min < 0 ? 0 : min;
			StringBuilder[] sbs=new StringBuilder[nRows];
			for (var i = 0; i < nRows; i++)
			{
				sbs [i] = new StringBuilder ();
			}
			for (var i = 0; i < s.Length; i++)
			{
				int idx = i % (max + min);
				if (idx < max)
				{
					sbs [idx].Append (s [i]);
				}
				else
				{
					var minRowIdx = max-2-(idx-max);
					sbs [minRowIdx].Append (s [i]);
				}
			}
			for (var i = 1; i < max; i++)
			{
				sbs [0].Append (sbs [i].ToString ());
			}
			return sbs [0].ToString ();
		}
	}
}


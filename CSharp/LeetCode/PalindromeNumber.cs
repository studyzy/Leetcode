using System;

namespace LeetCode
{
	
	public partial class Solution {
		/// <summary>
		/// Determines whether this instance is palindrome the specified x.Do this without extra space.
		/// https://leetcode.com/problems/palindrome-number/
		/// TODO 这道题主要有两步操作，先是循环除以10，得到x的位数d。
		/// 然后逐次比较第一位和最后一位，比较完了把x的第一位和最后一位去掉，继续比。
		/// </summary>
		/// <returns><c>true</c> if this instance is palindrome the specified x; otherwise, <c>false</c>.</returns>
		/// <param name="x">The x coordinate.</param>
		public Boolean IsPalindrome(int x) 
		{ 
			if (x < 0)
				return false;
			int d = 1;
			while (x / d > 10)
				d = d * 10;
			while (x > 0)
			{
				int left = x / d;
				int right = x % 10;
				if (left != right)
					return false;
				x = x % d / 10;
				d = d / 100;
			}
			return true;
		}
	}
}


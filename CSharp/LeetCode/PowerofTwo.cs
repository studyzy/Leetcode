using System;

namespace LeetCode
{
	public partial class Solution {
		public bool IsPowerOfTwo(int n) 
		{
			if (n == 1)
				return true;
			if (n < 1)
				return false;
			int x = 1;
			for (var i = 1; i < 32; i++)
			{
				x = x * 2;
				if (x == n)
				{
					return true;
				}
			}
			return false;
		}
	}
}


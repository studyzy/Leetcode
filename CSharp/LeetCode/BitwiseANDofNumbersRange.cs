using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/bitwise-and-of-numbers-range/
		/// m到n的and，那么必然包含m和n，所以先把这两个数and，每增加1步，2步，4步，8步，对应的最后的位数必然会and到0，从而就会变为0，所以可以右移的方式把右边的
		/// 位数变为0，右移完后再左移回来即可。
		/// </summary>
		/// <returns>The bitwise and.</returns>
		/// <param name="m">M.</param>
		/// <param name="n">N.</param>
		public int RangeBitwiseAnd(int m, int n) 
		{
//			int d = n - m;
//			int step = 0;
//			m = m & n;
//			while (d != 0)
//			{
//				m = m >> 1;
//				d = d >> 1;
//				step++;
//			}
//			for (var i = 0; i < step; i++)
//			{
//				m = m << 1;
//			}
//			return m;

			//Solution2:http://www.meetqun.com/thread-8769-1-1.html
			while(n > m) { 
				n = n & (n-1);
			}
			return n;

		}
	}
}


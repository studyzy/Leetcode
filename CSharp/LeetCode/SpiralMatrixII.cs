using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/spiral-matrix-ii/
		/// 模拟实现每一个单元格的数字填充即可
		/// </summary>
		/// <returns>The matrix.</returns>
		/// <param name="n">N.</param>
		public int[,] GenerateMatrix(int n) 
		{
			int[,] flags = new int[n, n];
			var rowp = 0;
			var colp = 0;
			int direct = 1;
			for (var i = 1; i <= n * n; i++)
			{
				flags [rowp, colp] = i;
				if (direct == 1)//往右
				{
					if (colp < n - 1 && flags[rowp, colp+1] == 0)//能够往右移动
					{

						colp++;
					}
					else//不能往右，就只能往下
					{
						rowp++;
						direct = 2;
					}
				}
				else if (direct == 2)//往下
				{
					if (rowp < n - 1 && flags[rowp+1, colp] == 0)
					{
						rowp++;
					}
					else//不能往下，就只能往左
					{
						colp--;
						direct = 3;
					}
				}
				else if (direct == 3)//往左
				{
					if (colp > 0 && flags[rowp, colp - 1] == 0)
					{
						colp--;
					}
					else//不能往左，只能往上
					{
						rowp--;
						direct = 4;
					}
				}
				else//4 往上
				{
					if (rowp > 0 && flags[rowp-1, colp] == 0)
					{
						rowp--;
					}
					else//不能往上，只有往右
					{
						colp++;
						direct = 1;
					}
				}
			}
			return flags;
		}
	}
}


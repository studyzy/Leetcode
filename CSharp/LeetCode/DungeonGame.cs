using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/dungeon-game/
		/// 反向思维，要让到达右下脚的时候血为1，那么进入右下角的时候，需要准备1-dungeon[右下角]的血，但是如果需要准备的血为负数，那么说明不需要准备血，只有血量为1活着进去就行了。
		/// 以此思路，从右到左，从下到上扫描即可。
		/// </summary>
		/// <returns>The minimum H.</returns>
		/// <param name="dungeon">Dungeon.</param>
		public int CalculateMinimumHP(int[,] dungeon) 
		{
			int row = dungeon.GetLength (0);
			int column = dungeon.GetLength (1);

			dungeon [row - 1, column - 1] = Math.Max(1, 1-dungeon [row - 1, column - 1] );


			for (var i = row-1; i >=0; i--)
			{
				for (var j = column-1; j >=0; j--)
				{
					if (i == row-1)//bottom
					{
						if (j != column-1)
						{
							dungeon [i, j] =Math.Max(1, dungeon [i, j + 1]-dungeon [i, j]);
						}
					}
					else//i<row-1
					{
						if (j == column-1)//right column
						{
							dungeon [i, j] =Math.Max(1,dungeon [i + 1, j]-dungeon [i, j]);
						}
						else//Normal
						{
							dungeon [i, j] =Math.Max(1, Math.Min (dungeon [i + 1, j], dungeon [i, j + 1])-dungeon [i, j]);
						}
					}
				}
			}
			return dungeon[0,0];
		}
	}
}


using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// 如果一个单元格为0，那么对于的第一行和第一列必然是0，所以只需要标识第一行和第一列对于的0.然后再根据第一行和第一列是否有0重置。
		/// </summary>
		/// <param name="matrix">Matrix.</param>
		public void SetZeroes(int[,] matrix)
		{
			int row = matrix.GetLength (0);
			int column = matrix.GetLength (1);
			bool firstRow0 = false;
			bool firstColumn0 = false;
			for (var i = 0; i < row; i++)
			{
				if (matrix [i, 0] == 0)
				{
					firstColumn0 = true;
					break;
				}
			}
			for (var i = 0; i < column; i++)
			{
				if (matrix [0, i] == 0)
				{
					firstRow0 = true;
					break;
				}
			}
			for (var i = 1; i < row; i++)
			{
				for (var j = 1; j < column; j++)
				{
					if (matrix [i, j] == 0)
					{
						matrix [i, 0] = 0;
						matrix [0, j] = 0;
					}
				}
			}
			for (var i = 1; i < row; i++)
			{
				for (var j = 1; j < column; j++)
				{
					if (matrix [0, j] == 0||matrix[i,0]==0)
					{
						matrix [i, j] = 0;
					}
				}
			}
			if (firstRow0)
			{
				for (var i = 0; i < column; i++)
				{
					matrix [0, i] = 0;
				}
			}
			if (firstColumn0)
			{
				for (var i = 0; i < row; i++)
				{
					matrix [ i,0] = 0;
				}
			}
		}

//		public void SetZeroes(int[,] matrix) 
//		{
//			var special = GetSpecialNumber (matrix);
//			int row = matrix.GetLength (0);
//			int column = matrix.GetLength (1);
//			for (var i = 0; i < row; i++)
//			{
//				for (var j = 0; j < column; j++)
//				{
//					if (matrix [i, j] == 0)
//					{
//						//set row 0
//						for (var jj = 0; jj < column; jj++)
//						{
//							if (matrix [i, jj] != 0)
//								matrix [i, jj] = special;
//						}
//						//set column 0
//						for (var ii = 0; ii < row; ii++)
//						{
//							if (matrix [ii, j] != 0)
//								matrix [ii, j] = special;
//						}
//					}
//				}
//			}
//			for (var i = 0; i < row; i++)
//			{
//				for (var j = 0; j < column; j++)
//				{
//					if (matrix [i, j] == special)
//						matrix [i, j] = 0;
//				}
//			}
//		}
//		private int GetSpecialNumber(int[,] matrix)
//		{
//
//			Random r = new Random ();
//			while (true)
//			{
//				int special = r.Next (int.MinValue, int.MaxValue);
//				if (special == 0)
//					continue;
//				bool find = true;
//				foreach (var i in matrix)
//				{
//					if (special == i)
//					{
//						find = false;
//						break;
//					}
//				}
//				if (find)
//				{
//					return special;
//				}
//			}
//		}
	}
}


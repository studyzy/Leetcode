using System;

namespace LeetCode
{
	public partial class Solution {
		/// <summary>
		/// https://leetcode.com/problems/rotate-image/
		/// 这道题看起来简单，但是要不使用额外的空间，在原矩阵中进行操作，则很麻烦。
		/// TODO 我没有做出来，答案是将矩阵进行两次翻转，一次是延对角线翻转，然后再进行上下翻转。
		/// </summary>
		/// <param name="matrix">Matrix.</param>
		public void Rotate(int[,] matrix) 
		{
			int n = matrix.GetLength (0);
			//沿对角线翻转
			for (var i = 0; i < n-1; i++)
			{
				for (var j = 0; j < n - i-1; j++)
				{
					//Swap a,b
					matrix [i, j] ^= matrix [n - j - 1, n - i - 1];
					matrix [n - j - 1, n - i - 1] ^= matrix [i, j];
					matrix [i, j] ^= matrix [n - j - 1, n - i - 1];
				}
			}
			//上下翻转
			for (var i = 0; i < n / 2; i++)
			{
				for (var j = 0; j < n; j++)
				{
					matrix [i, j] ^= matrix [n - i - 1, j];
					matrix [n - i - 1, j] ^= matrix [i, j];
					matrix [i, j] ^= matrix [n - i - 1, j];
				}
			}

		}

	}
}


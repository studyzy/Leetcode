using System;

namespace LeetCode
{
	public partial class Solution {
		/// <summary>
		/// https://leetcode.com/problems/rotate-image/
		/// 这道题看起来简单，但是要不使用额外的空间，在原矩阵中进行操作，则很麻烦。
		/// 使用异或的方式，对4个要换位置的数据进行互换，得到结果
		/// </summary>
		/// <param name="matrix">Matrix.</param>
		public void Rotate(int[,] matrix) 
		{
			int n = matrix.GetLength (0);
            ////沿对角线翻转
            //for (var i = 0; i < n-1; i++)
            //{
            //    for (var j = 0; j < n - i-1; j++)
            //    {
            //        //Swap a,b
            //        matrix [i, j] ^= matrix [n - j - 1, n - i - 1];
            //        matrix [n - j - 1, n - i - 1] ^= matrix [i, j];
            //        matrix [i, j] ^= matrix [n - j - 1, n - i - 1];
            //    }
            //}
            ////上下翻转
            //for (var i = 0; i < n / 2; i++)
            //{
            //    for (var j = 0; j < n; j++)
            //    {
            //        matrix [i, j] ^= matrix [n - i - 1, j];
            //        matrix [n - i - 1, j] ^= matrix [i, j];
            //        matrix [i, j] ^= matrix [n - i - 1, j];
            //    }
            //}
		    for (var i = 0; i < (n + 1)/2; i++)
		    {
		        for (var j = 0; j < n/2; j++)
		        {
                    //var a = matrix[i, j];
                    //var b = matrix[j, n - i - 1];
                    //var d = matrix[n - i - 1, n - j - 1];
                    //var c = matrix[n - j - 1, i];
		            matrix[i, j] = matrix[i, j] ^ matrix[j, n - i - 1] ^ matrix[n - i - 1, n - j - 1] ^ matrix[n - j - 1, i];
                    matrix[j, n - i - 1] = matrix[i, j] ^ matrix[j, n - i - 1] ^ matrix[n - i - 1, n - j - 1] ^ matrix[n - j - 1, i];
                    matrix[n - i - 1, n - j - 1] = matrix[i, j] ^ matrix[j, n - i - 1] ^ matrix[n - i - 1, n - j - 1] ^ matrix[n - j - 1, i];
                    matrix[n - j - 1, i] = matrix[i, j] ^ matrix[j, n - i - 1] ^ matrix[n - i - 1, n - j - 1] ^ matrix[n - j - 1, i];
                    matrix[i, j] = matrix[i, j] ^ matrix[j, n - i - 1] ^ matrix[n - i - 1, n - j - 1] ^ matrix[n - j - 1, i];
		        }
		    }


		}

	}
}


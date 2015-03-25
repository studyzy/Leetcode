using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/search-a-2d-matrix/
        /// </summary>
        /// <returns></returns>
        public bool SearchMatrix(int[,] matrix, int target)
        {
            var nrow = matrix.GetLength(0);
            var ncol = matrix.GetLength(1);
            for (var i = 0; i < nrow; i++)
            {
                if (matrix[nrow - i - 1,0] <= target)
                {
                    for (var j = 0; j < ncol; j++)
                    {
                        if (matrix[nrow - i - 1, j] == target)
                            return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}

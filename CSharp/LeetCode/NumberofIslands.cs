using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/number-of-islands/
        /// 递归，找到1的情况就对四周标注，并对四周为1的进行递归标注
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                var row = grid[i];
                for (int j = 0; j < row.Length; j++)
                {
                    var c = grid[i][j];
                    if (c == '0')
                    {
                        continue;
                    }
                    if (c == '1') //发现新岛屿
                    {
                        grid[i][j] = '2';//Flaged
                        FlagAroud(grid, i, j);
                        count++;
                    }
                }
            }
            return count;
        }

        private void FlagAroud(char[][] grid, int i, int j)
        {
    
            if (i > 0)//top
            {
                 if (grid[i - 1][j] == '1')
                {
                    grid[i - 1][j] = '2';
                    FlagAroud(grid, i - 1, j);
                }
            }
            if (j > 0) //left
            {
                 if (grid[i][j - 1] == '1')
                {
                    grid[i][j - 1] = '2';
                    FlagAroud(grid, i, j - 1);
                }
            }
            if (i < grid.Length - 1)//bottom
            {

                 if (grid[i + 1][j] == '1')
                {
                    grid[i + 1][j] = '2';
                    FlagAroud(grid, i+1, j );
                }
            }
            if (j < grid[0].Length - 1)
            {

                 if (grid[i][j + 1] == '1')
                {
                    grid[i][j + 1] = '2';
                    FlagAroud(grid, i, j + 1);
                }
            }

        }
    }
}

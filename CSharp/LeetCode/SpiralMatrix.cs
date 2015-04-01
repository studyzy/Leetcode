using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/spiral-matrix/
        /// 用的最蠢的方法实现的。没有找到什么捷径
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var nrow = matrix.GetLength(0);
            var ncol = matrix.GetLength(1);
                var result = new List<int>();
            if (nrow == 0 || ncol == 0)
            {
                return result;
            }
            int rowp = 0;
            int colp = 0;
            int count = nrow*ncol;
            int[,] flags=new int[nrow,ncol];
            flags[0, 0] = 1;
            //Direct: 1→  2↓  3←  4↑
            result.Add(matrix[rowp, colp]);
          
            for (int i = 1; i < count; i++)
            {
              
               var direct= flags[rowp, colp] ;
                if (direct == 1)//往右
                {
                    if (colp < ncol - 1 && flags[rowp, colp+1] == 0)//能够往右移动
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
                    if (rowp < nrow - 1 && flags[rowp+1, colp] == 0)
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
                result.Add(matrix[rowp, colp]);
                flags[rowp, colp] = direct;
            }
            return result;
        }
    }
}

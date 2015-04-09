using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/merge-sorted-array/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="m"></param>
        /// <param name="B"></param>
        /// <param name="n"></param>
        public void Merge(int[] A, int m, int[] B, int n)
        {
            var aindex = 0;
            var bindex = 0;
            for (var i = 0; i < m+n; i++)
            {
                if (aindex == m + bindex) //a已经填充完毕，把b填充进去
                {
                    A[i] = B[bindex++];
                    aindex++;
                    continue;
                }
                if (bindex == n)//b填充完毕,那么a什么都不需要做了
                {
                    return;
                }
                var a = A[aindex];
                var b = B[bindex];
                if (a > b)
                {
                    //a>b需要将b插入，然后a和后面的数组右移
                    RightMoveArray(A, m +bindex, aindex, b);
                    bindex++;
                    aindex++;
                }
                else
                {
                    aindex++;
                }
            }
        }

        private void RightMoveArray(int[] A, int len, int start,int insertNum)
        {
            for (int i = 0; i < len-start; i++)
            {
                A[len-i] = A[len -i- 1];
            }
            A[start] = insertNum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-element/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="elem"></param>
        /// <returns></returns>
        public int RemoveElement(int[] A, int elem)
        {
            int len = A.Length;
            for (int i = 0; i < len; i++)
            {
                if (A[i] == elem)
                {
                    MoveLeft(A,i);
                    len--;
                    i--;
                }
            }
            return len;

        }

        private void MoveLeft(int[] A, int start)
        {
            for (var i = start; i < A.Length-1; i++)
            {
                A[i] = A[i + 1];
            }
        }
    }
}

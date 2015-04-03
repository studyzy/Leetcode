using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }
          
            var result = new List<int>();
            int prev=A[0];
            //int count = 1;
            result.Add(prev);
            bool dupl = false;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == prev)
                {
                    if (!dupl)
                    {
                        //count++;
                        result.Add(A[i]);
                    }
                    dupl = true;

                }
                else
                {
                    //count++;
                    result.Add(A[i]);
                    dupl = false;
                    prev = A[i];
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                A[i] = result[i];
            }
            return result.Count;
        }
    }
}

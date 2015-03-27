using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/rotate-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="kk"></param>
        public void Rotate(int[] nums, int k)
        {
             int len = nums.Length;
            int kk = k%len;
            int[] c=new int[kk];
            if (len == 1)
            {
                return;
            }
            for (var i = 0; i < kk; i++)
            {
                c[i] = nums[ len- kk +i];
            }
            for (var i = 0; i < len-kk; i++)
            {
                nums[len - i - 1] = nums[len - i - kk - 1];
            }
            for (int i = 0; i < kk; i++)
            {
                nums[i] = c[i];
            }
            
        }
    }
}

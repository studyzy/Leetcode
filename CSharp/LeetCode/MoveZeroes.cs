using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// 非常简单，看左边有几个0，那么就左移几位
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            int left = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    left++;
                }
                else if (left != 0)
                {
                    nums[i - left] = nums[i];
                }
            }
            for (var i = 0; i < left; i++)
            {
                nums[nums.Length-1 - i] = 0;
            }
        }
    }
}

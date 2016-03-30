using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int MissingNumber(int[] nums)
        {
            nums= nums.OrderBy(n => n).ToArray();
            if (nums[0] != 0) return 0;
            for (var i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] + 1 != nums[i + 1])
                {
                    return nums[i] + 1;
                }
            }
            return nums[nums.Length-1]+1;
        }
    }
}

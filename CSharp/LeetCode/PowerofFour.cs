using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            for (var i = 0; i < 16; i++)
            {
                var result = 1 << (i*2);
                if (result == num) return true;
                if (result >num) return false;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-bits/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public uint ReverseBits(uint n)
        {

            uint result = 0;
            for (var i = 0; i < 32; i++)
            {
                var b = (uint)Math.Pow(2, i);
                if ((n & b) != 0)
                {
                    result += (uint)Math.Pow(2, 31 - i);
                }
            }
            return result;
        }
    }
}

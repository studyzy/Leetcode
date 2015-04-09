using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/factorial-trailing-zeroes/
        /// 计算5的个数，10里面包含1个5，25里面包含2个5
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int TrailingZeroes(int n)
        {
            int ret = 0;
            long baseNum = 5;//n数字大了会溢出
            while (n >= baseNum)
            {
                ret += n / (int)baseNum;
                baseNum *= 5;
            }
            return ret;  
        }
    }
}

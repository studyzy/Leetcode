using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/ugly-number/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsUgly(int num)
        {
            if (num <= 0)
                return false;
            while (true)
            {
                if (num%2 == 0)
                {
                    num = num/2;
                    continue;
                }
                if (num % 3 == 0)
                {
                    num = num / 3;
                    continue;
                }
                if (num % 5 == 0)
                {
                    num = num / 5;
                    continue;
                }
                if (num == 1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

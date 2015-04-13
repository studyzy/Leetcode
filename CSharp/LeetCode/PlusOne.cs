using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/plus-one/
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            List<int> result=new List<int>();
            int len = digits.Length;
            bool step = true;
            for (int i = 0; i < len; i++)
            {
                var d = digits[len - i - 1];

                if (step)
                {
                    d++;
                    if (d == 10)
                    {
                        result.Insert(0,0);
                    }
                    else
                    {
                        step = false;
                        result.Insert(0, d);
                    }
                }
                else
                {
                    result.Insert(0, d);
                }
            }
            if (step)
            {
                result.Insert(0, 1);
            }
            return result.ToArray();
        }
    }
}

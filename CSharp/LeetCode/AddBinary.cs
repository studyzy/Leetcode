using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/add-binary/
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public  string AddBinary(string a, string b)
        {
            string answer = "";
            int alen = a.Length;
            int blen = b.Length;
            int len = Math.Max(alen, blen);
            bool step = false;
            for (var i = 1; i <= len + 1; i++)
            {
                if (i == len + 1 && !step)
                {
                    continue;
                }
                var bit1 = false;
                var bit2 = false;
                if (alen >= i)
                {
                    bit1 = a[a.Length - i] == '1';
                }
                if (blen >= i)
                {
                    bit2 = b[b.Length - i] == '1';
                }
                var result = (bit1 ? 1 : 0) + (bit2 ? 1 : 0) + (step ? 1 : 0);
                if (result == 3)
                {
                    step = true;
                    answer = "1" + answer;
                }
                else if (result == 2)
                {
                    step = true;
                    answer = "0" + answer;
                }
                else if (result == 1)
                {
                    step = false;
                    answer = "1" + answer;
                }
                else if (result == 0)
                {
                    step = false;
                    answer = "0" + answer;
                }
            }
            return answer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/integer-to-roman/
        ///  罗马数字共有7个，即I（1）、V（5）、X（10）、L（50）、C（100）、D（500）和M（1000）
        /// </summary>
        /// <param name="num">1 to 3999.</param>
        /// <returns></returns>
        public string IntToRoman(int num)
        {
            StringBuilder sb=new StringBuilder();
            if (num >= 1000)
            {
                for (var i = 0; i < num/1000; i++) sb.Append("M");
            }
            var x2 = num%1000/100;
            sb.Append(BuildOne(x2, new[] {'C', 'D', 'M'}));
            var x3 = num%100/10;
            sb.Append(BuildOne(x3, new[] {'X', 'L', 'C'}));
            var x4 = num%10;
            sb.Append(BuildOne(x4, new[] { 'I', 'V', 'X' }));
            return sb.ToString();
        }

        private string BuildOne(int x, char[] cs)
        {
            StringBuilder sb=new StringBuilder();
            if (x >= 5 && x < 9)
            {
                sb.Append(cs[1]);
            }
            if ((x > 0 && x < 4)|| (x>5&&x<9))
            {
                for (int i = 0; i < x%5; i++)
                {
                    sb.Append(cs[0]);
                }
            }
            if (x == 4)
            {
                return cs[0].ToString() + cs[1];
            }
            if (x == 9)
            {
                return cs[0].ToString() + cs[2];
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/excel-sheet-column-title/
        /// 实际上就是一个26进制的数的表示，而是从1开始，不是从0开始
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public String ConvertToTitle(int n)
        {
            
            string result = "";
            while(true)
            {
                n--;
                var i = n%26;
                var c = (char) ((int) 'A' + i);
                result = c + result;
                n = n/26;
                if (n == 0)
                {
                    break;
                }
            }
            return result;
        }
    }
}

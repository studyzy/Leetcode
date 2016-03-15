using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int AddDigits(int num)
        {
           return (num - 1) % 9 + 1;//这个解法牛逼。得出公式
            //while (true)
            //{
            //    var i = num%10;
            //    num = num/10;
            //    num = i + num;
            //    if (num < 10)
            //    {
            //        return num;
            //    }

            //}
        }
    }
}

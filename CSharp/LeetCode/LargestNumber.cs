using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/largest-number/
        /// 比较两个数，判断哪个数字放前面，哪个放后面。
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string LargestNumber(int[] num)
        {
            if (num.Length == 0)
            {
                return "";
            }
            var list = num.ToList();
            
            list.Sort((a, b) =>
            {
                string x = a.ToString() + b;
                string y = b.ToString() + a;
                for (int i = 0; i < x.Length; i++)
                {
                    var c1 = x[i];
                    var c2 = y[i];
                    if (c1 != c2)
                    {
                        return c2 - c1;
                    }
                }
                return 0;
            });
            var sb = new System.Text.StringBuilder();
            foreach (int i in list)
            {
                sb.Append(i);
            }
            var result= sb.ToString();
            if (result[0] == '0')
            {
                return "0";
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/majority-element/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int MajorityElement(int[] num)
        {
            int n = num.Length;
            if (n == 1)
            {
                return num[0];
            }
            var dic=new Dictionary<int, int>();
            foreach (var i in num)
            {
                if (!dic.ContainsKey(i))
                {
                    dic[i] = 1;
                }
                else
                {
                    var count=dic[i];
                    if (count + 1 > n/2)
                    {
                        return i;
                    }
                    dic[i] = count + 1;
                }
            }
            return 0;
        }
    }
}

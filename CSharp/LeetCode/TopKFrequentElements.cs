using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dic=new Dictionary<int,int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic[num] = 1;
                }
            }
            var orderd = dic.OrderByDescending(kv => kv.Value).Select(kv=>kv.Key).ToList();
            return orderd.Take(k).ToList();
        }
    }
}

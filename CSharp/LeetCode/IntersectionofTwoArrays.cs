using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var result=new List<int>();
            foreach (var i in nums1)
            {
                foreach (var j in nums2)
                {
                    if (i == j)
                    {
                        if (!result.Contains(i))
                        {
                            result.Add(i);
                            break;
                        }

                    }
                    
                }
            }
            return result.ToArray();
        }
    }
}

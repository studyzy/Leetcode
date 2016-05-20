using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// 组合算法，循环取左边第一个，右边用递归取组合，然后和左边一个数组合起来
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<IList<int>> Combine(int n, int k)
        {
            return BackTracking(n, k,1);
        }


        private IList<IList<int>> BackTracking(int n, int k, int start)
        {
            var result = new List<IList<int>>();
            if ( k==1)
            {
              
                for (int i = 0; i < n-start+1; i++)
                {
                    var row = new List<int>();
                    row.Add(start+i);
                    result.Add(row);
                }
                return result;
            }
            for (var i = start; i < n; i++)
            {
                var rights = BackTracking(n, k - 1, i + 1);
                foreach (var right in rights)
                {
                    var row = new List<int>();
                    row.Add(i);
                    row.AddRange(right);
                    result.Add(row);
                }
            }
            return result;
        }

        
    }
}

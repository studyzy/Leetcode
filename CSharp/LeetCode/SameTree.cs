using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/same-tree/
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if ((p == null) || (q == null) || p.val != q.val)
            {
                return false;
            }
            
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}

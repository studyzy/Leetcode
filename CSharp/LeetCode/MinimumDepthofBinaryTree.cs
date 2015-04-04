using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null) //leaf
            {
                return 1;
            }
           
            int leftDepth = MinDepth(root.left);
            int rightDepth = MinDepth(root.right);
            if (root.left == null)
            {
                return rightDepth + 1;
            }
            if (root.right == null)
            {
                return leftDepth + 1;
            }
            return Math.Min(leftDepth, rightDepth) + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            var left = root.left;
            root.left = root.right;
            if (root.left != null) InvertTree(root.left);
            root.right = left;
            if (root.right != null) InvertTree(root.right);
            return root;
        }
    }
}

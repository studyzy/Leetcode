using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result=new List<int>();
            PreorderTraversal(root, result);
            return result;
        }

        private void PreorderTraversal(TreeNode root, IList<int> result)
        {
            if (root == null)
            {
               return;
            }
            result.Add(root.val);
            if (root.left != null)
            {
                PreorderTraversal(root.left, result);
            }
            if (root.right != null)
            {
                PreorderTraversal(root.right, result);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
        /// 和上一道题一模一样，只是把List.Add改为，List.Insert(0,xx)即可
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            LevelBottomOrder(new List<TreeNode>() { root }, result);
            return result;
        }
        private void LevelBottomOrder(IList<TreeNode> noods, IList<IList<int>> result)
        {
            var rows = new List<int>();
            var nextNoods = new List<TreeNode>();
            foreach (var n in noods)
            {
                rows.Add(n.val);
                if (n.left != null)
                {
                    nextNoods.Add(n.left);
                }
                if (n.right != null)
                {
                    nextNoods.Add(n.right);
                }
            }
            result.Insert(0,rows);
            if (nextNoods.Count > 0)
            {
                LevelBottomOrder(nextNoods, result);
            }
        }
    }
}

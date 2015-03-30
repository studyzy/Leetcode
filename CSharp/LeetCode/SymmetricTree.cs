using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/symmetric-tree/
        /// 广度优先遍历，找到每一层的所有元素，组成数组，然后对每一层的数组判断是否是对称的
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            IList<TreeNode> nextLevelNodes = new List<TreeNode>();
            nextLevelNodes.Add(root.left);
            nextLevelNodes.Add(root.right);
            return IsSymmetric(nextLevelNodes);
        }

        private bool IsSymmetric(IList<TreeNode> nodes)
        {
            IList<int?> nums=new int?[nodes.Count];
            IList<TreeNode> nextLevelNodes=new List<TreeNode>();
            for (int i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                if (node == null)
                {
                    nums[i] = null;
                }
                else
                {
                    nums[i] = node.val;
                    nextLevelNodes.Add(node.left);
                    nextLevelNodes.Add(node.right);
                }
            }
            for (int i = 0; i < nodes.Count/2; i++)
            {
                if (nums[i] != nums[nums.Count - i - 1])
                {
                    return false;
                }
            }
            if (nextLevelNodes.Count > 0)
            {
                return IsSymmetric(nextLevelNodes);
            }
            return true;
        }
    }
}

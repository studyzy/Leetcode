using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/binary-tree-right-side-view/
        /// 循环取每一层的最右边的元素
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }
            
            result.Add(root.val);
            IList<TreeNode>  currentLevel=new List<TreeNode>();
            currentLevel.Add(root);
            while (true)
            {
                currentLevel = GetNextLevelNodes(currentLevel);
                if (currentLevel.Count == 0)
                {
                    break;
                }
                result.Add(GetRightNumber(currentLevel));
            }
            return result;
        }

        private int GetRightNumber(IList<TreeNode> nodes)
        {
           return nodes[nodes.Count - 1].val;
        }

        private IList<TreeNode> GetNextLevelNodes(IList<TreeNode> nodes)
        {
            var list = new List<TreeNode>();
            foreach (TreeNode node in nodes)
            {
                if (node.left != null)
                {
                    list.Add(node.left);
                }
                if (node.right != null)
                {
                    list.Add(node.right);
                }
            }
            return list;
        }
    }
}

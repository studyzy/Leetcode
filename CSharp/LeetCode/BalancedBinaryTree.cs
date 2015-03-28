using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /**
  * Definition for binary tree
  * public class TreeNode {
  *     public int val;
  *     public TreeNode left;
  *     public TreeNode right;
  *     public TreeNode(int x) { val = x; }
  * }
  */
    
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/balanced-binary-tree/
        /// 深度优先遍历二叉树，然后给每个节点赋值
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            DepthSearchTree(root);
            return isBalance;
        }

        private bool isBalance = true;
        private void DepthSearchTree(TreeNode node)
        {
            int leftval = 0;
            int rightval = 0;
            if (node.left == null && node.right == null)
            {
                node.val = 1;
                return;
            }
            if (node.left != null)
            {
                DepthSearchTree(node.left);
                leftval = node.left.val;
            }
            if (node.right != null)
            {
                DepthSearchTree(node.right);
                rightval =node.right.val;
            }
            if (Math.Abs(leftval- rightval)>1)
            {
                isBalance = false;
                return;
            }
            node.val = Math.Max(leftval,rightval)+1;
        }
    }
}

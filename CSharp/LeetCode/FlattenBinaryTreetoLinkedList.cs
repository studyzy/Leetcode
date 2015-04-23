using System;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
		/// 递归出来即可
		/// </summary>
		/// <param name="root">Root.</param>
		public void Flatten(TreeNode root) 
		{
			if (root == null)
				return;
			Flat (root);
		}
		private TreeNode Flat(TreeNode root)
		{
			var left = root.left;

			var right = root.right;
			if (left == null && right == null)
			{
				return root;
			}
			TreeNode leftend;

			TreeNode rightend=null;
			if(right!=null) rightend= Flat (right);
			root.left = null;
			if (left != null)
			{
				leftend = Flat (left);
				root.right = left;
				if (right != null)
				{
					leftend.right = right;
					return rightend;
				}
				else
				{
					return leftend;
				}
			}
			//right!=null
			return rightend;
		}
	}
}


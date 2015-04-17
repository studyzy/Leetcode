using System;

namespace LeetCode
{
	public partial class Solution 
	{
		private int total = 0;
		/// <summary>
		/// https://leetcode.com/problems/sum-root-to-leaf-numbers/
		/// 递归即可，无技术含量
		/// </summary>
		/// <returns>The numbers.</returns>
		/// <param name="root">Root.</param>
		public int SumNumbers(TreeNode root) 
		{
			total = 0;
			if (root != null)
			{
				SumNumbers (root, 0);
			}
			return total;
		}
		private void SumNumbers(TreeNode nood,int parent)
		{
			int v = parent * 10 + nood.val;
			if (nood.left == null && nood.right == null)
			{
				total += v;
				return;
			}
			if (nood.left != null)
			{
				SumNumbers (nood.left, v);
			}
			if (nood.right != null)
			{
				SumNumbers (nood.right, v);
			}
		}

	}
}


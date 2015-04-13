using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution {
		
		public IList<IList<int>> LevelOrder(TreeNode root) 
		{
			IList<IList<int>> result=new List<IList<int>>();
			if (root == null)
			{
				return result;
			}

			LevelOrder (new List<TreeNode> (){ root },result);
			return result;
		}
		private void LevelOrder(IList<TreeNode> noods,IList<IList<int>> result)
		{
			var rows = new List<int> ();
			var nextNoods = new List<TreeNode> ();
			foreach(var n in noods)
			{
				rows.Add (n.val);
				if (n.left != null)
				{
					nextNoods.Add (n.left);
				}
				if (n.right != null)
				{
					nextNoods.Add (n.right);
				}
			}
			result.Add (rows);
			if (nextNoods.Count > 0)
			{
				LevelOrder (nextNoods,result);
			}
		}
	}
}


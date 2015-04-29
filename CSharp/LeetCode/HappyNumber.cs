using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution 
	{
		public bool IsHappy(int n) 
		{
			List<int> list = new List<int> ();
			list.Add (n);
			while (true)
			{
				int total = 0;
				foreach (char c in n.ToString())
				{
					int d=	c-'0';
					total += d * d;
				}
				if (total == 1)
					return true;
				if (list.Contains (total))
				{
					return false;
				}
				list.Add (total);
				n = total;
			}

		}
	}
}


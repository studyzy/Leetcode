using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution 
	{
		public int CountPrimes(int n)
		{
			if (n <= 2)
				return 0;
			
			int sqrt = (int)Math.Sqrt (n);
			var list = new bool[n];
			list [0] = true;
			list [1] = true;
			for (var i = 2; i <= sqrt; i++)
			{
				if (!list [i])
				{
					
					for (var j = i * i; j < n; j += i)
					{
						list [j] = true;
					}
				}
			}
			return list.Where (l => !l).Count ();
		}
	}
}


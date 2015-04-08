using System;

namespace LeetCode
{
	public partial class SolutionDuplicate {
		/// <summary>
		/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
		/// </summary>
		/// <returns>The duplicates.</returns>
		/// <param name="A">A.</param>
		public int RemoveDuplicates(int[] A) 
		{
			int len = A.Length;
			int step = 1;
			for (var i = 0; i < len-1; i++)
			{
				for (int j = i + step; j < len; j++)
				{
					if (A [i] == A [j])
					{
						step++;
						if (j != A.Length-1)
						{
							A [i + 1] = A [j + 1];
						}

					}
					else
					{
						if (j != A.Length)
						{
							A [i + 1] = A [j];
						}
						break;
					}
				}
			}
			var resultLen= len-step+1;
			return resultLen;
		}
	}
}


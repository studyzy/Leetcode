using System;
using System.Collections.Generic;
namespace LeetCode
{
	public partial class Solution {
		/// <summary>
		/// https://leetcode.com/problems/pascals-triangle/
		/// </summary>
		/// <param name="numRows">Number rows.</param>
		public IList<IList<int>> Generate(int numRows) {
			IList<IList<int>> result = new List<IList<int>> ();
			if (numRows == 0) {
				return result;
			}
			IList<int> row1 = new List<int> ();
			row1.Add (1);
			result.Add (row1);//initial first row is 1
			for (var i = 2; i <= numRows; i++) {
				IList<int> row2 = new List<int> ();
				row2.Add (1);//left one is 1
				for (var j = 0; j < i - 2; j++) {
					int n = row1 [j] + row1 [j + 1];
					row2.Add (n);
				}
				row2.Add (1);// last one is 1
				row1=row2;
				result.Add (row1);
			}
			return result;
		}
	}
}


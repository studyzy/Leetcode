using System;
using System.Collections.Generic;
using System.Globalization;

namespace LeetCode
{
	public partial class Solution {
		/// <summary>
        /// https://leetcode.com/problems/pascals-triangle-ii/
		/// </summary>
        /// <param name="rowIndex">Number rows.</param>
        public IList<int> GetRow(int rowIndex)
		{
		    var result = new int[rowIndex+1];
		    result[0] = 1;
		    for (var i = 0; i < rowIndex; i++)
		    {
		        for (var j = i+1; j >0; j--)
		        {
		            result[j] += result[j - 1];
		        }
		    }
		    return result;
		}
	}
}


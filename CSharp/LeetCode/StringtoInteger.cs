using System;

namespace LeetCode
{
	public  partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/string-to-integer-atoi/
		/// </summary>
		/// <param name="str">String.</param>
		public int Atoi(string str) 
		{
			str = str.Trim ();
			long result = 0;
			bool negative = false;
			for ( int i =0;i< str.Length;i++)
			{
				char c = str [i];
				if (i == 0)
				{
					if (c == '-')
					{
						negative = true;
						continue;
					}
					if (c == '+')
						continue;
					 
				}
				if (c == ',')
					continue;
				if (c >= '0' && c <= '9')
				{
					result = result * 10 + (c - '0');
					if (result >= int.MaxValue)
						break;
				}
				else
				{
					break;
				}
			}
			if (negative)
				result = -result;
			if (result > Int32.MaxValue )
			{
				return int.MaxValue;
			}
			if (result < Int32.MinValue)
			{
				return int.MinValue;
			}
			return (int)result;

		}

	}
}


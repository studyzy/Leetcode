using System;
using System.Text;

namespace LeetCode
{
	public partial class Solution {
		public string ReverseWords(string s) {
			var array=s.Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
			var sb = new System.Text.StringBuilder ();
			int len = array.Length;
			for (int i = 0; i < len; i++) {
				sb.Append (array [len - i - 1]);
				if (i != len - 1) {
					sb.Append (" ");
				}
			}
			return sb.ToString ();
		}
	}
}


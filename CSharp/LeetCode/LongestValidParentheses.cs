using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution {

		/// <summary>
		/// https://leetcode.com/problems/longest-valid-parentheses/
		/// TODO 想到了用栈，但是没想通怎么做。该代码需要复习。
		/// </summary>
		/// <returns>The valid parentheses.</returns>
		/// <param name="s">S.</param>
		public int LongestValidParentheses(string s) {
			Stack<int> lefts = new Stack<int> ();

			int max = 0;
			int last = -1;
			for(var i=0;i<s.Length;i++){
				char c = s [i];
				if (c == '(') {
					lefts.Push (i);

				}
				else {
					if (lefts.Count== 0) {
						last = i;
					}
					else {
						lefts.Pop ();
						if (lefts.Count == 0) {
							max = Math.Max (max, i - last);
						}
						else {
							max = Math.Max (max, i - lefts.Peek());
						}

					}
				}
			}
			return max;
		}
	}
}


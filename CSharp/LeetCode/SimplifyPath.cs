using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/simplify-path/
		/// 用栈实现，最后把栈弹出组成字符串即可。
		/// 注意细节，如果是根目录，返回"/"而不是空字符串。
		/// </summary>
		/// <returns>The path.</returns>
		/// <param name="path">Path.</param>
		public string SimplifyPath(string path) 
		{
			if (path == "" || path == "/")
			{
				return "/";
			}
			Stack<string> stack = new Stack<string> ();
			var folders = path.Split ('/');
			foreach (var folder in folders)
			{
				if (folder == "..")
				{
					if (stack.Count > 0)
					{
						stack.Pop ();
					}
					continue;
				}
				if (folder == "." || folder == "")
				{
					continue;
				}
				stack.Push (folder);
			}
			string str = "";
			while (stack.Count > 0)
			{
				str = "/"+stack.Pop () + str;
			}
			if (str == "")
			{
				str="/";
			}
			return str;
		}
	}
}


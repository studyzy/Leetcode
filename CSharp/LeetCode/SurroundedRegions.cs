using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution 
	{
		/// <summary>
		/// https://leetcode.com/problems/surrounded-regions/
		/// TODO 如果是递归搜索，会堆栈溢出。必须改为非递归算法
		/// 于是用一个栈来保存需要需要保留的点。
		/// </summary>
		/// <param name="board">Board.</param>
		public void Solve(char[][] board) 
		{
			int rowCount = board.Length;
			if (rowCount == 0)
			{
				return;
			}
			char[] row1 = board [0];
			char[] rowEnd = board [rowCount - 1];
			int columnCount=row1.Length;
			for (var i = 0; i < columnCount; i++)
			{
				char c = row1 [i];
				if (c == 'O')
				{
					FlagK (board, 0, i);
				}
				c = rowEnd [i];
				if (c == 'O')
				{
					FlagK (board, rowCount-1, i);
				}
			}
			for (var i = 1; i < rowCount-1; i++)
			{
				char c = board [i] [0];
				if (c == 'O')
				{
					FlagK (board, i,0);
				}
				c = board [i] [columnCount - 1];
				if (c == 'O')
				{
					FlagK (board, i,columnCount-1);
				}
			}
			for (var i = 0; i < rowCount; i++)
			{
				for (var j = 0; j < columnCount; j++)
				{
					if (board [i] [j] == 'K')
					{
						board [i] [j] = 'O';
					}
					else
					{
						board [i] [j] = 'X';
					}
				}
			}

		}
		private void FlagK(char[][] board,int i,int j)
		{
			
			Stack<KeyValuePair<int,int>> stack = new Stack<KeyValuePair<int, int>> ();
			stack.Push (new KeyValuePair<int, int> (i, j));
			while (stack.Count > 0)
			{
				var top = stack.Pop ();
				i = top.Key;
				j = top.Value;
				board [i] [j] = 'K';
				if (i > 0 && board [i - 1] [j] == 'O')//top
				{
					stack.Push (new KeyValuePair<int, int> (i - 1, j));
				}
				if (j > 0 && board [i] [j - 1] == 'O')//left
				{
					stack.Push (new KeyValuePair<int, int> (i, j - 1));
				}
				if (i < board.Length - 1 && board [i + 1] [j] == 'O')//bottom
				{
					stack.Push (new KeyValuePair<int, int> (i + 1, j));
				}
				if (j < board [0].Length - 1 && board [i] [j + 1] == 'O')//right
				{
					stack.Push (new KeyValuePair<int, int> (i, j + 1));
				}
			}
		}
	}
}


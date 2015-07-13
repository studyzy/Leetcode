using System;
using System.Collections.Generic;
using System.Collections;

namespace LeetCode
{


	public class BSTIterator
	{
		readonly Stack<TreeNode> _mystack = new Stack<TreeNode>(); 
		public BSTIterator(TreeNode root)
		{
			findMostLeftNode(root);
		}

		/** @return whether we have a next smallest number */
		public bool HasNext()
		{
			return _mystack.Count > 0;
		}

		/** @return the next smallest number */
		public int Next()
		{
			var top = _mystack.Pop();
			findMostLeftNode(top.right);

			return top.val;
		}

		private void findMostLeftNode(TreeNode root)
		{
			while (root != null)
			{
				_mystack.Push(root);
				root = root.left;
			}
		}
	}

	public class BSTIterator2
	{
		private bool leftUsed=false;
		private Stack<TreeNode> stack=new Stack<TreeNode>();
		public BSTIterator2(TreeNode root) 
		{
			if(root!=null)

			stack.Push (root);
		}

		/** @return whether we have a next smallest number */
		public bool HasNext() 
		{
			return stack.Count > 0;
		}

		/** @return the next smallest number */
		public int Next() 
		{
			return GetMin (stack.Peek());
		}

		private int GetMin(TreeNode t)
		{

			if (t.left != null&&!leftUsed)
			{
				stack.Push (t.left);
			
				return GetMin (t.left);
			}
			if (t.left == null && t.right == null)
			{
				leftUsed = true;

				stack.Pop ();

				return t.val;
			}
			if (t.right == null)
			{
				leftUsed = false;
				stack.Pop();
				return t.val;
			}
			//left is null or used but t.right!=null
			var tree=stack.Pop();
			leftUsed = false;
			stack.Push( t.right);
			return tree.val;

		}
	}

}


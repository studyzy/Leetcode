using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using LeetCode;

namespace LeetCodeUT
{
    public class BaseUT
    {
        protected Solution Solution;
		protected SolutionDuplicate Solution2;
        public BaseUT()
        {
            Solution =new Solution();
			Solution2 = new SolutionDuplicate ();
        }

        protected IList<int> String2Int32List(string str)
        {
            var array = str.Split(',');
            var result = new List<int>();
            foreach (var s in array)
            {
                result.Add(Convert.ToInt32(s));
            }
            return result;
        }
		protected int[] String2Int32Array(string str)
		{
			var array = str.Split(',');
			var result = new List<int>();
			foreach (var s in array)
			{
				result.Add(Convert.ToInt32(s));
			}
			return result.ToArray();
		}
        #region List
        protected void PrintListNodes(ListNode n)
        {
            var p = n;
            while (p != null)
            {
                Debug.Write(p.val);
                p = p.next;

                Debug.WriteIf(p != null, "->");

            }
            Debug.WriteLine("");
        }

        protected ListNode BuildListNodes(string values)
        {
            var list = String2Int32List(values);
            return BuildListNodes(list.ToArray());
        }
        protected ListNode BuildListNodes(int[] values)
        {
            ListNode head=new ListNode(values[0]);
            ListNode p = head;
            for (int i = 1; i < values.Length; i++)
            {
                ListNode n=new ListNode(values[i]);
                p.next = n;
                p = n;
            }
            return head;
        }

        protected string ListToString(ListNode n)
        {
            StringBuilder sb=new StringBuilder();
            var p = n;
            while (p != null)
            {
               sb.Append(p.val);
                p = p.next;

                if(p != null)
                {
                    sb.Append(",");
                }

            }
            return sb.ToString();
        }
        #endregion

        #region TreeNode

        protected TreeNode BuildTree(string str)
        {
            var array = str.Split(',').ToList();
            TreeNode root=new TreeNode(Convert.ToInt32(array[0]));
            array.RemoveAt(0);
            BuildTree(array, new List<TreeNode> {root});
            return root;
        }

        private void BuildTree(List<string> str, IList<TreeNode> nodes)
        {
            if (str==null||str.Count==0)
            {
                return ;
            }
            var subNodes = new List<TreeNode>();
            var count = nodes.Count*2;
           
            for (var i = 0; i < count; i++)
            {
                if (i == str.Count)
                {
                    break;
                }
                var c = str[i];
                if (c != "#")
                {
                    int val = Convert.ToInt32(c);
                    var node = new TreeNode(val);
                    if (i%2 == 0)
                    {
                        nodes[i/2].left = node;
                    }
                    else
                    {
                        nodes[i/2].right = node;
                    }
                    subNodes.Add(node);
                }
            }
            if (str.Count > count)
            {
                var subStr = str.GetRange(count, str.Count - count);
                BuildTree(subStr, subNodes);
            }
        }

        #endregion
    }
}

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
       
        public BaseUT()
        {
            Solution =new Solution();
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

        protected ListNode ListBuilder(int[] values)
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
            var array = str.Split(',');
            TreeNode root=new TreeNode(Convert.ToInt32(array[0]));
            TreeNode current = root;
            bool fillLeft = false;
            for (int i = 1; i < array.Length; i++)
            {
                string v = array[i];
                if (v == "#")//该节点缺失
                {
                    fillLeft = true;
                    continue;
                }
                int val = Convert.ToInt32(v);
                if (fillLeft)
                {
                    current.right=new TreeNode(val);

                }
                else
                {
                    current.left=new TreeNode(val);
                }
            }
            return root;
        }
        #endregion
    }
}

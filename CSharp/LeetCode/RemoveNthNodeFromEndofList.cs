using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        /// 很简单，把每个节点的序号和节点放入Dictionary，然后根据总数算出要移除第几个，移除即可
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 0;
            ListNode p=head;
            Dictionary<int,ListNode> dic=new Dictionary<int, ListNode>();
            while (p!=null)
            {
                dic.Add(count++,p);
                p = p.next;
            }
            int idx = count - n - 1;
            if (idx < 0)
            {
                return head.next;
            }
            var left = dic[idx];
            left.next = left.next.next;
            return head;
        }
    }
}

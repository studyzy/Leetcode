using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// 循环放入堆栈中，然后一个一个取出即可。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            Stack<ListNode> stack=new Stack<ListNode>();
            do
            {
                stack.Push(head);
                head = head.next;
            } while (head != null);
            head = stack.Pop();
            var point = head;
            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                point.next = stack.Pop();
                point = point.next;
            }
            point.next = null;
            return head;

        }
    }
}

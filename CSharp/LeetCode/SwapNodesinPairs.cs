using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/swap-nodes-in-pairs/
        /// 没啥难度，设置几个指针，把指针交换即可
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode result;
            if (head.next == null)
            {
                return head;
            }
            else
            {
                result = head.next;
            }
            ListNode p = head;
            ListNode end = null;
            while (p != null && p.next != null)
            {
                var a = p;
                var b = p.next;
                var c = p.next.next;
                b.next = a;
                a.next = c;
                if (end != null)
                {
                    end.next = b;
                }
                end = a;

                p = p.next;

            }
            return result;
        }
    }
}

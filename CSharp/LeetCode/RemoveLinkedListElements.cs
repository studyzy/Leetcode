using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-linked-list-elements/
        /// 先找到Head，然后对剩下的元素for循环一次删除即可
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode RemoveElements(ListNode head, int val)
        {

            if (head == null)
                return null;
            while (head.val==val)
            {
                head = head.next;
                if (head == null)
                    return null;
            }

            ListNode p = head.next;
            ListNode prev = head;
            while (p!=null)
            {

                if (p.val == val)
                {
                    prev.next = p.next;
                }
                else
                {
                    prev = p;
                }
                p = p.next;
            }
            return head;
        }
    }
}

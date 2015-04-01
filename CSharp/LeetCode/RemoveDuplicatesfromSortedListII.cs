using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
        /// TODO 这道题需要学习一下
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
           
            var p = head.next;
            if (head.val == p.val)//remove duplicate
            {
                while (p!=null && head.val==p.val)
                {
                    p = p.next;
                }
                return DeleteDuplicates(p);
            }
            else
            {
                head.next = DeleteDuplicates(head.next);
                return head;
            }
         
        }
    }
}

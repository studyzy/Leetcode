using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/add-two-numbers/
        /// TODO 代码写的凌乱，有待改进
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode p1 = l1;
            ListNode p2 = l2;
         
            var sum = p1.val + p2.val;
            ListNode result =new ListNode(sum%10);
            var p0 = result;
            int step = (sum) /10;
            while (p1.next != null||step>0||p2.next!=null)
            {
                int n1 = 0, n2 = 0;
                if (p1.next != null)
                {
                    n1 = p1.next.val;
                }
                if (p2.next != null)
                {
                    n2 = p2.next.val;
                }
                var v = n1+n2 + step;

                p0.next = new ListNode(v % 10);
                p0 = p0.next;
                step = v/10;
                if(p1.next!=null)
                p1 = p1.next;
                if(p2.next!=null)
                p2 = p2.next;
              
            } 
           
            return result;
        }
    }
}

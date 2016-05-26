using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// TODO 这道题没做好，网上找的答案。
        /// 正确思路为：
        /// 分为两个步骤，第一步是找到m结点所在位置，第二步就是进行反转直到n结点。
        /// 反转的方法就是每读到一个结点，把它插入到m结点前面位置，然后m结点接到读到结点的下一个。
        /// 总共只需要一次扫描，所以时间是O(n)，只需要几个辅助指针，空间是O(1)。
        /// </summary>
        /// <param name="head"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null)
                return null;
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode preNode = dummy;
            int i = 1;
            while (preNode.next != null && i < m)
            {
                preNode = preNode.next;
                i++;
            }
            if (i < m)
                return head;
            ListNode mNode = preNode.next;
            ListNode cur = mNode.next;
            while (cur != null && i < n)
            {
                ListNode next = cur.next;
                cur.next = preNode.next;
                preNode.next = cur;
                mNode.next = next;
                cur = next;
                i++;
            }
            return dummy.next;
        }
    }
}

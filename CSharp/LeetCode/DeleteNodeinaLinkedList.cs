using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        ///  这个题是给定一个单链表，给你要删除的节点，然后目标是删除这个节点，维持单链表的其它都不变
        ///* 变量中只给定了要删除的节点，如果对其删除操作，因为单链表其前一个节点是不知道的，
        ///* 所以他的前一个节点就会找不到下一个节点，这种情况时不允许的。
        ///* 这里换一种思路，把要删除的节点A的下一个节点B的值赋给A，然后让A指向B的下一个节点，这样虽然删除的是规定节点的下一个节点
        ///* 但是删除的确实规定节点的值，所以满足要求
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

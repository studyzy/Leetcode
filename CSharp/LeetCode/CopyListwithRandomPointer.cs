using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        Dictionary<RandomListNode,RandomListNode> dictionary=new Dictionary<RandomListNode, RandomListNode>(); 
        /// <summary>
        /// https://leetcode.com/problems/copy-list-with-random-pointer/
        /// 非常简单，连UT都没有写就通过了。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (dictionary.ContainsKey(head))
            {
                return dictionary[head];
            }
            var copy = new RandomListNode(head.label);
            dictionary.Add(head,copy);
            if(head.next!=null)
            copy.next = CopyRandomList(head.next);
            if (head.random != null)
                copy.random = CopyRandomList(head.random);
            return copy;
        }
    }
}

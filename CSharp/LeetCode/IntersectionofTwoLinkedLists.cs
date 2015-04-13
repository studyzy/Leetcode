using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution 
	{
		public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
		{
			int lenA = 0;
			int lenB = 0;
			var pA = headA;

			while (pA != null)
			{
				lenA++;
				pA = pA.next;
			}
			var pB = headB;
			while (pB != null)
			{
				lenB++;
				pB = pB.next;
			}
			if (lenA < lenB)
			{
				var step = lenB - lenA;
				for (var i = 0; i < step; i++)
				{
					headB = headB.next;
				}
			}
			else
			{
				var step = lenA - lenB;
				for (var i = 0; i < step; i++)
				{
					headA = headA.next;
				}
			}
			ListNode intersection = null;
			for (var i = 0; i < Math.Min (lenA, lenB); i++)
			{
				if (headA.val == headB.val)
				{
					if(intersection==null)
					intersection = headA;
				}
				else
				{
					intersection = null;
				}
				headA = headA.next;
				headB = headB.next;
			}
			return intersection;
		}
	}
}


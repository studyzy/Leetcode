using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RemoveDuplicatesfromSortedListIIUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            ListNode head = ListBuilder(new[] {1, 1, 2, 3, 4, 4});
           var result= Solution.DeleteDuplicates(head);
            PrintListNodes(result);
            Assert.AreEqual(ListToString(result),"2,3");
        }


        [Test]
        public void Test2()
        {
            ListNode head = ListBuilder(new[] { 1, 2, 2 });
            var result = Solution.DeleteDuplicates(head);
            PrintListNodes(result);
            Assert.AreEqual(ListToString(result), "1");
        }
        [Test]
        public void Test3()
        {
            ListNode head = ListBuilder(new[] { 1, 2, 2,2,2,3,4,4 });
            var result = Solution.DeleteDuplicates(head);
            PrintListNodes(result);
            Assert.AreEqual(ListToString(result), "1,3");
        }
    }
}

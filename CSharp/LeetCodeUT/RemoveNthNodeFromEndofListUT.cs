using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RemoveNthNodeFromEndofListUT:BaseUT
    {
        [TestCase("1,2,3,4,5,6",2,"1,2,3,4,6")]
        [TestCase("1,2,3,4,5,6", 3, "1,2,3,5,6")]
        [TestCase("1", 1, "")]
        [TestCase("1,2", 1, "1")]
        [TestCase("1,2,3", 3, "2,3")]
        public void Test(string list,int n, string result)
        {
            var head = BuildListNodes(list);
            head = Solution.RemoveNthFromEnd(head, n);
            Assert.AreEqual(ListToString(head),result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RemoveLinkedListElementsUT:BaseUT
    {
        [TestCase("1,2,3,4,5",4,"1,2,3,5")]
        [TestCase("1,2,3,4,4,4,5", 4, "1,2,3,5")]
        [TestCase("1,2,3,4,5", 5, "1,2,3,4")]
        [TestCase("1,2,3,4,5", 1, "2,3,4,5")]
        [TestCase("1,1,1", 1, "")]
        [TestCase("1,2,3,4,5", 6, "1,2,3,4,5")]

        public void Test(string list, int val, string newList)
        {
           var head=  BuildListNodes(list);
            var head2 = Solution.RemoveElements(head, val);
            var result = ListToString(head2);
            Assert.AreEqual(result,newList);
        }
    }
}

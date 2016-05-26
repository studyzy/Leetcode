using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ReverseLinkedListIIUT:BaseUT
    {
        [TestCase("1,2,3,4,5",2,4,"1,4,3,2,5")]
        [TestCase("1,2,3,4,5",2,5,"1,5,4,3,2")]
        [TestCase("1,2,3,4,5",1,4,"4,3,2,1,5")]
        [TestCase("1,2,3,4,5",1,5,"5,4,3,2,1")]
        public void Test(string input, int m, int n, string reversed)
        {
          var head=  BuildListNodes(input);
            var result = Solution.ReverseBetween(head, m, n);
            Assert.AreEqual(ListToString(result),reversed);
        }
    }
}

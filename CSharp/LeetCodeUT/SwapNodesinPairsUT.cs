using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class SwapNodesinPairsUT:BaseUT
    {
         [TestCase("1", "1")]
         [TestCase("1,2", "2,1")]
        [TestCase("1,2,3,4","2,1,4,3")]
        [TestCase("1,2,3,4,5", "2,1,4,3,5")]
        public void Test(string input, string output)
        {
            var head = BuildListNodes(input);
            var result = Solution.SwapPairs(head);
            Assert.AreEqual(ListToString(result), output);
        }
    }
}

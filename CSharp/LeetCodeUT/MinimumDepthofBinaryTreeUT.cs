using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MinimumDepthofBinaryTreeUT:BaseUT
    {
        [TestCase("1,2,2,#,#,#,3",2)]
        [TestCase("1,2", 2)]
        public void Test(string tree,int depth)
        {
            var root = BuildTree(tree);
            Assert.AreEqual(Solution.MinDepth(root),depth);
        }
    }
}

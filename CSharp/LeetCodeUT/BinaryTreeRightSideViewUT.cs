using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class BinaryTreeRightSideViewUT:BaseUT
    {
        [TestCase("1", "1")]
        [TestCase("1,2,3", "1,3")]
        [TestCase("1,2,3,#,5,#,#,6,#", "1,3,5,6")]
        public void Test(string tree, string result)
        {
            var root = BuildTree(tree);
            var numbers = Solution.RightSideView(root);
            Assert.AreEqual(String.Join(",", numbers), result);
        }
    }
}

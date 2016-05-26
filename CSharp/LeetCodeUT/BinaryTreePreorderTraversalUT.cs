using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class BinaryTreePreorderTraversalUT:BaseUT
    {
        [TestCase("1,#,2,3","1,2,3")]
        [TestCase("1,2,3,4,5,6","1,2,4,5,3,6")]
        public void Test(string binTree, string result)
        {
            var root = BuildTree(binTree);
           var list= Solution.PreorderTraversal(root);
            var str = String.Join(",", list);
            Assert.AreEqual(str,result);
        }
    }
}

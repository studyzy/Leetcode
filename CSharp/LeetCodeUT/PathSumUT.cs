using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class PathSumUT:BaseUT
    {
        [TestCase("5,4,8,11,#,13,4,7,2,#,#,#,1",22)]
        public void TestTrue(string tree,int n)
        {
            var root = BuildTree(tree);
            Assert.IsTrue(Solution.HasPathSum(root,n));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class SameTreeUT:BaseUT
    {
        [TestCase("1,2,3,4,#", "1,2,3,4,#",true)]
        [TestCase("1,2,3,4,#", "1,2,3,#,4",false)]
        public void Test(string atree, string btree, bool same)
        {
            var p = BuildTree(atree);
            var q = BuildTree(btree);
            Assert.AreEqual(Solution.IsSameTree(p, q), same);
        }
    }
}

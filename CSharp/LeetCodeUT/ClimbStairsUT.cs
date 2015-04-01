using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ClimbStairsUT:BaseUT
    {
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        [TestCase(4,5)]
        [TestCase(5,8)]
        public void Test(int n,int result)
        {
            var r = Solution.ClimbStairs(n);
            Assert.AreEqual(r,result);
        }
    }
}

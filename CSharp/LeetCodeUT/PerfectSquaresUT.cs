using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class PerfectSquaresUT:BaseUT
    {
        [TestCase(12,3)]
        [TestCase(13,2)]
        public void Test(int num,int result)
        {
            Assert.AreEqual(Solution.NumSquares(num), result);
        }
    }
}

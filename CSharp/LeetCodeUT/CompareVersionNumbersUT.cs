using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class CompareVersionNumbersUT:BaseUT
    {
        [TestCase("1.2","1.11",-1)]
        [TestCase("1.20","1.11",1)]
        [TestCase("1.1","1",1)]
        public void Test(string v1, string v2, int result)
        {
            Assert.AreEqual(Solution.CompareVersion(v1,v2),result);
        }
    }
}

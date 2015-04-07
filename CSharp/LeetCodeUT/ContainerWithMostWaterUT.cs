using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ContainerWithMostWaterUT:BaseUT
    {
        [TestCase("1,2,0,3,2,3,4",10)]
        [TestCase("1,1",1)]
        public void Test(string height, int max)
        {
            var result = Solution.MaxArea(String2Int32List(height));
            Assert.AreEqual(result,max);
        }
    }
}

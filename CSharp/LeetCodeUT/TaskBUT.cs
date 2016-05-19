using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class TaskBUT:BaseUT
    {
        [TestCase("1,2,4,5,7,29,30",11)]
        [TestCase("1,2,4,5,7,28,29,30",13)]
        [TestCase("1,2,4,5,7,26,28,29,30",14)]
        [TestCase("1,2,4,5,7,26,27,28,29,30",14)]
        [TestCase("1,5,6,7,8,9,10,11",9)]
        [TestCase("1,2,5,6,7,8,9,10,11",11)]
        [TestCase("11",2)]
        [TestCase("",0)]
        public void TestMinCost(string arrayA,int minCost)
        {
            int[] A = String2Int32Array(arrayA);
            var cost = Solution.solution2(A);
            Assert.AreEqual(cost,minCost);
        }
    }
}

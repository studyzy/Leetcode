using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class TaskAUT:BaseUT
    {
        [TestCase("10:00","10:00",2)]
        [TestCase("10:00","10:01",5)]
        [TestCase("10:59","11:01",5)]
        [TestCase("10:59","11:59",5)]
        [TestCase("10:00","13:21",17)]
        public void TestFee(string E, string L,int fee)
        {
            var result = Solution.solutionA(E, L);
            Assert.AreEqual(result,fee);
        }

    }
}

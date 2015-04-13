using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class PascalsTriangleIIUT:BaseUT
    {
        [TestCase(1,"1,1")]
        [TestCase(2,"1,2,1")]
        [TestCase(3,"1,3,3,1")]
        [TestCase(4,"1,4,6,4,1")]
        public void Test(int row, string result)
        {
           var list= Solution.GetRow(row);
            Assert.AreEqual(String.Join(",",list),result);
        }
    }
}

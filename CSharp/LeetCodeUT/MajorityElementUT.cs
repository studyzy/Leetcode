using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MajorityElementUT:BaseUT
    {
        [TestCase("1,5,7,1,1,1,1,4",1)]
        [TestCase("1,1,2",1)]
        [TestCase("1",1)]
        public void Test(string list,int number)
        {
            var array = String2Int32Array(list);
            Assert.AreEqual(Solution.MajorityElement(array),number);
        }
    }
}

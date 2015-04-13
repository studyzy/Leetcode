using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class PlusOneUT:BaseUT
    {
        [TestCase("1,2,3,4","1,2,3,5")]
        [TestCase("1,2,3,9","1,2,4,0")]
        [TestCase("9", "1,0")]
        public void Test(string num, string result)
        {
            var array = String2Int32Array(num);
            Assert.AreEqual(String.Join("," ,Solution.PlusOne(array)),result);
        }
    }
}

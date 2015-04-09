using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MultiplyStringsUT:BaseUT
    {
        [TestCase("123","456","56088")]
        [TestCase("2", "3", "6")]
        [TestCase("2", "5", "10")]
        [TestCase("0", "0", "0")]

        public void Test(string a, string b, string result)
        {
            Assert.AreEqual(Solution.Multiply(a, b), result);
        }
    }
}

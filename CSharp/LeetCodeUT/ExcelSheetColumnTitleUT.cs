using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ExcelSheetColumnTitleUT:BaseUT
    {
        [TestCase(1,"A")]
        [TestCase(26,"Z")]
        [TestCase(27,"AA")]
        [TestCase(28, "AB")]
        [TestCase(53,"BA")]
        [TestCase(729,"ABA")]
        public void Test(int n, string result)
        {
            Assert.AreEqual(Solution.ConvertToTitle(n),result);
        }
    }
}

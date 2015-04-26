using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class FractiontoRecurringDecimalUT:BaseUT
    {
        [TestCase(1,7,"0.(142857)")]
        [TestCase(6, 7, "0.(857142)")]
        [TestCase(1, 3, "0.(3)")]
        [TestCase(2, 3, "0.(6)")]
        [TestCase(0, 3, "0")]
        [TestCase(7, 5, "1.4")]
        [TestCase(-50, 8, "-6.25")]
        [TestCase(1, 97, "0.(010309278350515463917525773195876288659793814432989690721649484536082474226804123711340206185567)")]
        [TestCase(7, -12, "-0.58(3)")]
        [TestCase(12345, 410, "30.1(09756)")]
        [TestCase(-2147483648, -1, "2147483648")]
        [TestCase(-1, -2147483648, "0.0000000004656612873077392578125")]
        public void Test(int n1, int n2, string result)
        {
            var m = Solution.FractionToDecimal(n1, n2);
            Debug.WriteLine(m);
            Assert.AreEqual(m, result);
        }
    }
}

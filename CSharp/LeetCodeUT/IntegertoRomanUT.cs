using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class IntegertoRomanUT:BaseUT
    {
        [TestCase(1986, "MCMLXXXVI")]
        public void Test(int i, string roman)
        {
            Assert.AreEqual(Solution.IntToRoman(i),roman);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RomantoIntegerUT:BaseUT
    {
        [TestCase("MCMLXXXVI",1986)]
        public void Test(string s, int result)
        {
            var r = Solution.RomanToInt(s);
            Assert.AreEqual(r,result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class LengthOfLastWordUT:BaseUT
    {
        [TestCase("Hello World",5)]
        [TestCase("Hello World    ", 5)]
        [TestCase("", 0)]
        public void Test(string s, int len)
        {
            var result = Solution.LengthOfLastWord(s);
            Assert.AreEqual(result,len);
        }
    }
}

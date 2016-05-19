using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ReverseStringUT:BaseUT
    {
        [TestCase("abcd","dcba")]
        public void Test(string input,string reverse)
        {
            Assert.AreEqual(Solution.ReverseString(input), reverse);
        }
    }
}

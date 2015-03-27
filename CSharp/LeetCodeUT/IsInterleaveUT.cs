using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class IsInterleaveUT:BaseUT
    {
        [TestCase("aabcc", "dbbca", "aadbbcbcac")]
        public void TestTrue(string a, string b, string c)
        {
            Assert.IsTrue(Solution.IsInterleave(a, b, c));
        }
         [TestCase("aabcc", "dbbca", "aadbbbaccc")]
        public void TestFalse(string a, string b, string c)
        {
            Assert.IsFalse(Solution.IsInterleave(a, b, c));
        }
    }
}

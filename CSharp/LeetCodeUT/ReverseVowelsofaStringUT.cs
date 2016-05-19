using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ReverseVowelsofaStringUT:BaseUT
    {
        [TestCase("hello", "holle")]
        [TestCase("leetcode", "leotcede")]
        [TestCase("a", "a")]
        [TestCase("x", "x")]
        [TestCase("axo", "oxa")]
        [TestCase("aA", "Aa")]
        public void Test(string input, string result)
        {
            Assert.AreEqual(Solution.ReverseVowels(input),result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class LongestPalindromeUT:BaseUT
    {
        [TestCase("012343210","012343210")]
        [TestCase("01234321","1234321")]
        [TestCase("01234341","343")]
        [TestCase("abb","bb")]
        [TestCase("ccd","cc")]
        [TestCase("eee","eee")]
        [TestCase("gg","gg")]
        [TestCase("abbbc","bbb")]
        [TestCase("abbccb","bccb")]
        [TestCase("abbccba","bccb")]
        [TestCase("aaaa","aaaa")]
        public void Test(string s, string result)
        {
           var sub= Solution.LongestPalindrome(s);
            Assert.AreEqual(sub,result);
        }
    }
}

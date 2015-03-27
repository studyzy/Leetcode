using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class LongestCommonPrefixUT:BaseUT
    {
        [Test]
        public void Test1()

        {
            string[] strs = new[] {"abcd","abce"};
            var result = Solution.LongestCommonPrefix(strs);
            Assert.AreEqual(result,"abc");
        }

        [Test]
        public void Test2()
        {
            string[] strs = new[] { "abcd", "abc" };
            var result = Solution.LongestCommonPrefix(strs);
            Assert.AreEqual(result, "abc");
        }

        [Test]
        public void Test3()
        {
            string[] strs = new[] { "abc", "abce" };
            var result = Solution.LongestCommonPrefix(strs);
            Assert.AreEqual(result, "abc");
        }
    }
}

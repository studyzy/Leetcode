using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ImplementstrStrUT:BaseUT
    {
        [TestCase("12345678","345",2)]
        [TestCase("12345678","3457",-1)]
        [TestCase("12345678","345678",2)]
        [TestCase("12345678","1",0)]
        [TestCase("12345678", "78910", -1)]
        [TestCase("", "1", -1)]
        [TestCase("aaa", "aaaa", -1)]
        public void Test(string str, string search, int idx)
        {
            var result = Solution.StrStr(str, search);
            Assert.AreEqual(result,idx);
        }
    }
}

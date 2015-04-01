using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class CountAndSayUT:BaseUT
    {
        [TestCase(1,"1")]
        [TestCase(2,"11")]
        [TestCase(3,"21")]
        [TestCase(4,"1211")]
        [TestCase(5, "111221")]
        public void Test(int n,string result)
        {
           var str =Solution.CountAndSay(n);
            Assert.AreEqual(str,result);
        }
    }
}

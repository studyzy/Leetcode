using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MaximumProductofWordLengthsUT:BaseUT
    {
        [TestCase("abcw,baz,foo,bar,xtfn,abcdef",16)]
        [TestCase("a,ab,abc,d,cd,bcd,abcd", 4)]
        [TestCase("a,aa,aaa,aaaa",0)]
        public void Test(string arrays,int result)
        {
            var array = arrays.Split(',');
            var product = Solution.MaxProduct(array);
            Assert.AreEqual(product,result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    public class UglyNumberUT : BaseUT
    {
        [TestCase(1,true)]
        [TestCase(8,true)]
        [TestCase(6,true)]
        [TestCase(14,false)]
        public void Test(int num,bool result)
        {
            var c = Solution.IsUgly(num);
            Assert.AreEqual(result,c);
        }
    }
}

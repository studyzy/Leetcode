using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    public class AddDigitsUT : BaseUT
    {
        [TestCase(0,0)]
        [TestCase(8,8)]
        [TestCase(10,1)]
        [TestCase(38,2)]
        public void Test(int num,int result)
        {
            var c = Solution.AddDigits(num);
            Assert.AreEqual(result,c);
        }
    }
}

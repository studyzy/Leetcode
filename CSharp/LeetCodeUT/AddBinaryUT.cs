using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    public class AddBinaryUT : BaseUT
    {
        [TestCase("100","1101","10001")]
        public void Test(string a,string b,string result)
        {
            var c = Solution.AddBinary(a, b);
            Assert.AreEqual(result,c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ValidPalindromeUT:BaseUT
    {
        [TestCase("A man, a plan, a canal: Panama",true)]
        [TestCase("race a car",false)]
        [TestCase("1a2",false)]
        public void Test(string str, bool result)
        {
            Assert.AreEqual(Solution.IsPalindrome(str),result);
        }
    }
}

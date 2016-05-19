using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ValidAnagramUT:BaseUT
    {
        [TestCase("anagram", "nagaram",true)]
        [TestCase("rat", "car",false)]
        public void Test(string s,string t,bool result)
        {
            Assert.AreEqual(Solution.IsAnagram(s, t), result);
        }
    }
}

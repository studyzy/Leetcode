using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class WordPatternUT:BaseUT
    {
        [TestCase("abba", "dog cat cat dog",true)]
        [TestCase("abba", "dog dog dog dog", false)]
        public void Test(string partern, string input, bool result)
        {
            Assert.AreEqual(Solution.WordPattern(partern, input), result);
        }
    }
}

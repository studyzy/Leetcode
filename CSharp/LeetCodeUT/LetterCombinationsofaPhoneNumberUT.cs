using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class LetterCombinationsofaPhoneNumberUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            var strings = Solution.LetterCombinations("23");
            var answer = new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
            foreach (var s in strings)
            {
                Debug.WriteLine(s);
                Assert.Contains(s,answer);
            }
           

        }

        [Test]
        public void Test2()
        {
            var strings = Solution.LetterCombinations("2");
            var answer = new[] { "a","b","c" };
            foreach (var s in strings)
            {
                Debug.WriteLine(s);
                Assert.Contains(s, answer);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ValidParenthesesUT:BaseUT
    {
        [TestCase("()[{}]")]
        [TestCase("(()[{}])")]
        [TestCase("[()[{}][]]")]
        [TestCase("")]
        public void TestValid(string s)
        {
            Assert.IsTrue(Solution.IsValid(s));
        }
        [TestCase("[(]{)}")]
        [TestCase("[{}")]
        [TestCase("]")]
        [TestCase("([)(){}{}]")]
        public void TestInvalid(string s)
        {
            Assert.IsFalse(Solution.IsValid(s));
        }
    }
}

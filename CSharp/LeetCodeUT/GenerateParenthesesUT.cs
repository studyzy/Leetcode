using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class GenerateParenthesesUT:BaseUT
    {
        [TestCase(2, "()(),(())")]
        [TestCase(3,"()()(),(())(),((())),()(()),(()())")]
        [TestCase(4, "(((()))),((()())),((())()),(()(())),()()()(),()(())(),()((())),(())(()),(()()()),()()(()),()(()()),(())()(),(()())(),((()))()")]
        public void Test(int n, string str)
        {
            var array = str.Split(',');
           var result= Solution.GenerateParenthesis(n);
            foreach (var s in result)
            {
                Debug.WriteLine(s);
                Assert.Contains(s,array);
            }
        }
    }
}

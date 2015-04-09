using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class FactorialTrailingZeroesUT:BaseUT
    {
        [TestCase(0,0)]
        [TestCase(1,0)]
        [TestCase(5,1)]
        [TestCase(10,2)]
        [TestCase(30,7)]
        [TestCase(50, 12)]
        [TestCase(100,24)]
        [TestCase(2147483647, 536870902)]
        public void Test(int n, int count)
        {
            Assert.AreEqual(Solution.TrailingZeroes(n),count);
        }
        [TestCase(30)]
        [TestCase(50)]
        public void TestCalcuate(int n)
        {
            Debug.WriteLine(Factorial(n));
        }

        private string Factorial(int n)
        {
            if (n == 1)
            {
                return "1";
            }
           
            var n1 = Factorial(n - 1);
           
            var result= Solution.Multiply(n.ToString(),n1);
             if (n%10 == 5 || n%10 == 0)
            {
                Debug.WriteLine(n+":"+result);
            }
            return result;
        }
    }
}

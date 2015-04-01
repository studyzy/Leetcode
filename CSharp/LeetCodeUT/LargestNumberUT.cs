using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class LargestNumberUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            int[] num = new[] {8, 91, 9, 97};
            var result = Solution.LargestNumber(num);
            Assert.AreEqual(result,"997918");
        }
        [Test]
        public void Test2()
        {
            int[] num = new[] { 8, 91, 9, 97,23456 };
            var result = Solution.LargestNumber(num);
            Assert.AreEqual(result, "99791823456");
        }
        [Test]
        public void Test3()
        {
            int[] num = new[] { 8, 91, 9, 97, 23456,9,8,9 };
            var result = Solution.LargestNumber(num);
            Assert.AreEqual(result, "99997918823456");
        }
        [Test]
        public void Test4()
        {
            int[] num = new[] {12,128 };
            var result = Solution.LargestNumber(num);
            Assert.AreEqual(result, "12812");
        }
        [Test]
        public void Test0()
        {
            int[] num = new[] { 0, 0 };
            var result = Solution.LargestNumber(num);
            Assert.AreEqual(result, "0");
        }
    }
}

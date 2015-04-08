using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class AddTwoNumbersUT:BaseUT
    {
        [Test]
        public void Test()
        {
            var l1 = BuildListNodes(new[] {2, 4, 3});
            var l2 = BuildListNodes(new[] {5, 6, 4});
            var r = Solution.AddTwoNumbers(l1, l2);
            PrintListNodes(r);
            Assert.AreEqual(ListToString(r),"7,0,8");
        }
        [Test]
        public void Test2()
        {
            var l1 = BuildListNodes(new[] { 2, 4, 3 });
            var l2 = BuildListNodes(new[] { 5, 6, 9 });
            var r = Solution.AddTwoNumbers(l1, l2);
            PrintListNodes(r);
            Assert.AreEqual(ListToString(r), "7,0,3,1");
        }
        [Test]
        public void Test3()
        {
            var l1 = BuildListNodes(new[] { 1,8 });
            var l2 = BuildListNodes(new[] { 0 });
            var r = Solution.AddTwoNumbers(l1, l2);
            PrintListNodes(r);
            Assert.AreEqual(ListToString(r), "1,8");
        }
    }
}

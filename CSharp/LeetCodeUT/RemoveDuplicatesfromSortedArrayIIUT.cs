using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RemoveDuplicatesfromSortedArrayIIUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            int[] a = {1, 1, 1, 2, 2, 3};
            Assert.AreEqual(
                Solution.RemoveDuplicates(a), 5);
            Debug.WriteLine(string.Join(",",a));
        }
        [Test]
        public void Test2()
        {
            int[] a = { 1 };
            Assert.AreEqual(
                Solution.RemoveDuplicates(a), 1);
            Debug.WriteLine(string.Join(",", a));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MergeSortedArrayUT:BaseUT
    {
        [Test]
        public void Test()
        {
            int[] a = new int[10];
            new int[] {1, 3, 5, 7, 9}.CopyTo(a, 0);
            int[] b = new[] {2, 4, 4, 6, 8};
            Solution.Merge(a,5,b,5);
            var result = String.Join(",", a);
            Debug.WriteLine(result);
            Assert.AreEqual(result,"1,2,3,4,4,5,6,7,8,9");
        }

        [Test]
        public void Test2()
        {
            int[] a = new int[5];
            new int[] { 1, 2,3 }.CopyTo(a, 0);
            int[] b = new[] { 4,5 };
            Solution.Merge(a, 3, b, 2);
            var result = String.Join(",", a);

            Assert.AreEqual(result, "1,2,3,4,5");
        }
        [Test]
        public void Test3()
        {
            int[] a = new int[5];
            new int[] { 4,5,6}.CopyTo(a, 0);
            int[] b = new[] { 1,2 };
            Solution.Merge(a, 3, b, 2);
            var result = String.Join(",", a);

            Assert.AreEqual(result, "1,2,4,5,6");
        }

        [Test]
        public void Test4()
        {
            int[] a = new int[5];
            new int[] { 1,2,4, 5, 6 }.CopyTo(a, 0);
            int[] b = new int[0];
            Solution.Merge(a, 5, b, 0);
            var result = String.Join(",", a);

            Assert.AreEqual(result, "1,2,4,5,6");
        }

        [Test]
        public void Test5()
        {
            int[] a = new int[5];
            new int[] { 1, 2, 4, 5, 6 }.CopyTo(a, 0);
            int[] b = new int[5];
            Solution.Merge(b, 0,a, 5);
            var result = String.Join(",", a);

            Assert.AreEqual(result, "1,2,4,5,6");
        }
    }
}

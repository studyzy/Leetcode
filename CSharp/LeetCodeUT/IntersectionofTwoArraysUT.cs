using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class IntersectionofTwoArraysUT:BaseUT
    {
        [Test]
        public void Test()
        {
           var nums1 =new [] { 1, 2, 2, 1};
            var nums2 = new[] {2, 2};
            var result = Solution.Intersection(nums1, nums2);
            Assert.AreEqual(string.Join(",",result),"2");
        }
    }
}

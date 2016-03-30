using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MissingNumberUT : BaseUT
    {
        [Test]
        public void Test()
        {
            int[] nums = new[] {0, 1, 3};
            var x = Solution.MissingNumber(nums);
            Assert.AreEqual(x,2);

            nums = new[] { 0, 1, 2 };
            x = Solution.MissingNumber(nums);
            Assert.AreEqual(x, 3);

            nums = new[] { 1, 0 };
            x = Solution.MissingNumber(nums);
            Assert.AreEqual(x, 2);
        }
    }
}

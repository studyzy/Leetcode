using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class PowerofFourUT:BaseUT
    {
        [TestCase(1,true)]
        [TestCase(4,true)]
        [TestCase(5,false)]
        [TestCase(3,false)]
        [TestCase(8,false)]
        [TestCase(64,true)]
        public void Test(int num, bool result)
        {
            Assert.AreEqual(Solution.IsPowerOfFour(num), result);
        }
    }
}

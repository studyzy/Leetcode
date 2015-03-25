using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ReverseBitsUT:BaseUT
    {
        [TestCase(43261596u, 964176192u)]
        public void Test(uint a,uint b)
        {
          var result= Solution.ReverseBits(a);
            Assert.AreEqual(result,b);
        }
    }
}

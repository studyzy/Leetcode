using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class SingleNumberIIIUT:BaseUT
    {
        [TestCase("1,2,3,4,5,3,4,1","2,5")]
        public void Test(string input,string result)
        {
            var array = String2Int32Array(input);
            var single2 = Solution.SingleNumber(array);
            Assert.AreEqual(String.Join(",", single2.OrderBy(a=>a)), result);
        }
    }
}

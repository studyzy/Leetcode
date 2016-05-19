using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class TopKFrequentElementsUT:BaseUT
    {
        [TestCase("1,1,1,2,2,3",2,"1,2")]
        [TestCase("1,1,1,2,2,3",1,"1")]
        [TestCase("1,1,1,2,2,3",3,"1,2,3")]
        public void Test(string array,int k,string result)
        {
            var ints = String2Int32Array(array);
            var list = Solution.TopKFrequent(ints, k);
            Assert.AreEqual(string.Join(",", list), result);
        }
    }
}

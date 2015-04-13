using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RemoveElementUT:BaseUT
    {
        [TestCase("1,2,3,4,6,7,4,3",3,6)]
        [TestCase("4,5",4,1)]
        public void Test(string array, int element, int len)
        {
           var A= String2Int32Array(array);
            var result = Solution.RemoveElement(A, element);
            Debug.WriteLine(String.Join(",",A));
            Assert.AreEqual(result,len);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class MoveZeroesUT:BaseUT
    {
        [TestCase("0,1,3,2","1,3,2,0")]
        [TestCase("0,0,1,3,2","1,3,2,0,0")]
        [TestCase("0,1,3,0,2","1,3,2,0,0")]
        [TestCase("0,1,3,2,0","1,3,2,0,0")]
        public void Test(string arrayString,string result)
        {
            var array = String2Int32Array(arrayString);
            Solution.MoveZeroes(array);
            Assert.AreEqual(String.Join(",",array),result );
        }
    }
}

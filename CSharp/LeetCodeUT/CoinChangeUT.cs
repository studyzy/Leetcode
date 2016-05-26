using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class CoinChangeUT:BaseUT
    {
        [TestCase("1,5,2",11,3)]
        public void Test(string coins, int amount, int result)
        {
           var array= String2Int32Array(coins);
            Assert.AreEqual(Solution.CoinChange(array, amount), result);
        }
    }
}

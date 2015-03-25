using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    internal class SearchMatrixUT : BaseUT
    {
        [TestCase(11, true)]
        [TestCase(12, false)]
        [TestCase(0, false)]
        [TestCase(-3, false)]
        public void Test1(int target, bool result)
        {
            int[,] matrix = new[,]
            {
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50}
            };
            Assert.AreEqual(Solution.SearchMatrix(matrix, target), result);

        }
    }
}

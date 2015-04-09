using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class NumberofIslandsUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            var grid = new char[][]
            {
                new char[] {'1', '0', '1', '1', '1'},
                new char[] {'1', '0', '1', '0', '1'},
                new char[] {'1', '1', '1', '0', '1'},
            };
            var i = Solution.NumIslands(grid);
            Assert.AreEqual(i, 1);
        }

        [Test]
        public void Test3()
        {
            var grid = new char[][] {
                new char[] {'1', '1', '1'},
                new char[] {'0', '1', '0'},
                new char[] {'1', '1', '1'}, };
            var i = Solution.NumIslands(grid);
            Assert.AreEqual(i, 1);
        }

        [Test]
        public void TestNull()
        {
            var grid = new char[][]{};
            var i = Solution.NumIslands(grid);
            Assert.AreEqual(i, 0);
        }
    }
}

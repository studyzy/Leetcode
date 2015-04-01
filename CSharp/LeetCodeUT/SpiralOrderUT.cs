using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class SpiralOrderUT:BaseUT
    {
        [Test]
        public void Test1()
        {
            var matrix = new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            var result=Solution.SpiralOrder(matrix);
            var str = string.Join(",", result);
            Debug.WriteLine(str);
            Assert.AreEqual(str, "1,2,3,6,9,8,7,4,5");
        }
        [Test]
        public void Test2()
        {
            var matrix = new int[,] { { 1, 2, 3,4 }, {  5, 6,7,8 }, { 9,10,11,12 },{13,14,15,16} };
            var result = Solution.SpiralOrder(matrix);
            var str = string.Join(",", result);
            Debug.WriteLine(str);
            Assert.AreEqual(str, "1,2,3,4,8,12,16,15,14,13,9,5,6,7,11,10");
        }
        [Test]
        public void Test3()
        {
            var matrix = new int[,] { };
            var result = Solution.SpiralOrder(matrix);
            var str = string.Join(",", result);
            Debug.WriteLine(str);
            Assert.AreEqual(str, "");
        }
        [Test]
        public void Test4()
        {
            var matrix = new int[,] { {1}};
            var result = Solution.SpiralOrder(matrix);
            var str = string.Join(",", result);
            Debug.WriteLine(str);
            Assert.AreEqual(str, "1");
        }
    }
}

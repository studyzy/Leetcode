using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class RotateArrayUT:BaseUT
    {
        [TestCase(3,5)]

        public void Test(int k,int firstNum)
        {
            int[] array = new[] {1, 2, 3, 4, 5, 6, 7};
            Solution.Rotate(array,k);
            Debug.WriteLine(String.Join(",",array));
            Assert.AreEqual(array[0],firstNum);
        }
         [TestCase(2, -1)]
        public void Test2(int k, int firstNum)
        {
            int[] array = new[] { -1 };
            Solution.Rotate(array, k);
            Debug.WriteLine(String.Join(",", array));
            Assert.AreEqual(array[0], firstNum);
        }
    }
}

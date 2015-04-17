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

        public void Test1(int k,int firstNum)
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
		[TestCase("1,2,3,4,5,6",2,5)]
		[TestCase("1,2,3,4,5,6",3,4)]
		[TestCase("1,2,3,4,5,6",4,3)]
		[TestCase("1,2,3,4,5,6",5,2)]
		[TestCase("1,2,3,4,5,6",6,1)]
		[TestCase("1,2,3,4,5,6,7",1,7)]
		[TestCase("1,2,3,4,5,6,7",2,6)]
		[TestCase("1,2,3,4,5,6,7",3,5)]
		[TestCase("1,2,3,4,5,6,7",0,1)]
		public void Test(string array,int step,int first)
		{
			int[] arr = String2Int32Array (array);
			Solution.Rotate (arr, step);
			Console.WriteLine (string.Join (",", arr));
			Assert.AreEqual (arr [0], first);
		}
    }
}

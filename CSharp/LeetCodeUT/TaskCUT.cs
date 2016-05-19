using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class TaskCUT:BaseUT
    {
        [Test]
        public void TestCountryCount()
        {
            int[][] A=new int[7][];
            A[0]=new []{5,4,4};
            A[1]=new []{4,3,4};
            A[2]=new []{3,2,4};
            A[3]=new []{2,2,2};
            A[4]=new []{3,3,4};
            A[5]=new []{1,4,4};
            A[6]=new []{4,1,1};
           int country= Solution.solution(A);
            Assert.AreEqual(country,11);
        }

        [Test]
        public void Test2CountryCount()
        {
            int[][] A = new int[1][];
            A[0] = new[] {111};
         
            int country = Solution.solution(A);
            Assert.AreEqual(country, 1);
        }

        [Test]
        public void Test3CountryCount()
        {
            int[][] A = new int[1][];
            A[0] = new[] { 111, 111,111 };

            int country = Solution.solution(A);
            Assert.AreEqual(country, 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class CombinationsUT:BaseUT
    {
        [TestCase(4,2)]
        [TestCase(4,3)]
        [TestCase(4,1)]
        public void Test(int n,int k)
        {
            var result = Solution.Combine(n, k);


            Debug.WriteLine("Count:"+result.Count);
            foreach (var row in result)
            {
                Debug.WriteLine(String.Join(",",row));
            }
        }
    }
}

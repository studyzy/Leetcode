using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class TitleToNumberUT:BaseUT
    {
       [TestCase("C",3)]
       [TestCase("AA",27)]
       [TestCase("BA",53)]
       [TestCase("ABA",729)]
        public void Test(string a,int result)
        {
           var b= Solution.TitleToNumber(a);
            Assert.AreEqual(result,b);
           
        }
    }
}

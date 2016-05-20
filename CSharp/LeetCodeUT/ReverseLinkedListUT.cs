using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class ReverseLinkedListUT:BaseUT
    {
        [TestCase("1,2,3","3,2,1")]
        [TestCase("1","1")]
        public void Test(string list,string result)
        {
            var head = BuildListNodes(list);
           head= Solution.ReverseList(head);
           var str= ListToString(head);
            Assert.AreEqual(str,result);
        }
    }
}

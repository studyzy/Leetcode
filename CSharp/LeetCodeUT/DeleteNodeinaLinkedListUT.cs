using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class DeleteNodeinaLinkedListUT:BaseUT
    {
        [Test]
        public void Test()
        {
            var nodes = BuildListNodes("1,2,3,4");
            var node3 = nodes.next.next;
            Solution.DeleteNode(node3);
            var result = ListToString(nodes);
            Assert.AreEqual(result,"1,2,4");
        }
        
    }
}

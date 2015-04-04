using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LeetCodeUT
{
    class UtilityUT:BaseUT
    {
        [Test]
        public void TestBuildTree()
        {
            string str = "1,2,2,#,#,#,3,4,#,#,5";
            var root = BuildTree(str);
        }
    }
}

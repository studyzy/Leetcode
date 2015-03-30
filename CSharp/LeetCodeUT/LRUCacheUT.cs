using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeUT
{
    class LRUCacheUT:BaseUT
    {
        [Test]
        public void Test()
        {
            LRUCache cache=new LRUCache(2);
            cache.Set(2,1);
            cache.Set(2,2);
            cache.Get(2);
            cache.Set(1, 1);
            cache.Set(4, 1);
            cache.Get(2);
        }
    }
}

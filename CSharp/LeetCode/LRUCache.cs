using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/lru-cache/
    /// 虽然实现了，但是性能极烂，惭愧
    /// </summary>
    public class LRUCache
    {

        private int capacity;
        private int count;
        private int identity = 0;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!dict.ContainsKey(key))
            {
                return -1;
            }
            var v = dict[key];
            dicTime[key] = identity++;
            return v;
        }
        Dictionary<int,int> dict=new Dictionary<int, int>();
        Dictionary<int, int> dicTime = new Dictionary<int, int>(); 
        public void Set(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
                dicTime[key] = identity++;
                return;
            }
            if (count == capacity)//Full must remove 1
            {
                var d = dicTime.Min(k => k.Value);
                var row = dicTime.Single(kv => kv.Value == d);
                dict.Remove(row.Key);
                dicTime.Remove(row.Key);
            }
            else
            {
                count++;
            }
            dict.Add(key, value);
            dicTime[key]=identity++;
        }
    }
}
